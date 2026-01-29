using System;
using System.IO;
using System.Threading;
using BenchUtil;

public class BulkImageProcAsync
{
 public const String ImageBaseName = "tmpImage-";
 public const int numImages = 200;
 public const int numPixels = 512 * 512;

 // ProcessImage has a simple O(N) loop, and we can vary the number 
 // of times we repeat that loop to make the app more CPU-bound or 
 // more IO-bound.
 public static int processImageRepeats = 20;

 // Threads must decrement NumImagesToFinish, and protect 
 // their access to it via a mutex.
 public static int NumImagesToFinish = numImages;
 public static Object NumImagesMutex = new Object[0];

 // WaitObject is signalled when all image processing is done.
 public static Object WaitObject = new Object[0];
 internal static PerfTimer Pf = new PerfTimer("Asynchronous Bulk Image Processor");

 public class ImageStateObject
 {
  public byte[] pixels;
  public int imageNum;
 }

 public static void MakeImageFiles()
 {
  int sides = (int)Math.Sqrt(numPixels);
  Console.Write("Making " + numImages + " " + sides + "x" + sides + " images... ");
  byte[] pixels = new byte[numPixels];

  for (int i = 0; i < numPixels; i++)
   pixels[i] = (byte)i;

  for (int i = 0; i < numImages; i++)
  {
   FileStream fs = new FileStream(ImageBaseName + i + ".tmp", FileMode.Create, FileAccess.Write, FileShare.None, 8192, false);
   fs.Write(pixels, 0, pixels.Length);
   FlushFileBuffers(fs.GetHandle());
   fs.Close();
  }
  Console.WriteLine("Done.");
 }

 public static void ReadInImageCallback(IAsyncResult asyncResult)
 {
  ImageStateObject state = (ImageStateObject)asyncResult.AsyncState;
  Console.WriteLine("Image " + state.imageNum + " was read. " + (asyncResult.CompletedSynchronously ? "synchronously" : "asynchronously"));

  Stream stream = (Stream)asyncResult.AsyncObject;
  int bytesRead = stream.EndRead(asyncResult);
  if (bytesRead != numPixels)
   throw new Exception("In ReadInImageCallback, got wrong number of bytes from the image! got: " + bytesRead);

  ProcessImage(state.pixels, state.imageNum);
  stream.Close();

  // Now write out the image.
  // Using async IO here probably swamps the threadpool, since 
  // there are blocked threadpool threads on soon-to-be-spawned 
  // threadpool threads.
  FileStream fs = new FileStream(ImageBaseName + state.imageNum + ".done", FileMode.Create, FileAccess.Write, FileShare.None, 4096, false);
  fs.Write(state.pixels, 0, numPixels);
  //IAsyncResult writeResult = fs.BeginWrite(state.pixels, 0, numPixels, null, null);
  //fs.EndWrite(writeResult);
  fs.Close();

  // Release memory as soon as possible, especially global state.
  state.pixels = null;

  // Record that an image is done now.
  lock (NumImagesMutex)
  {
   NumImagesToFinish--;
   if (NumImagesToFinish == 0)
   {
    Monitor.Enter(WaitObject);
    Monitor.Pulse(WaitObject);
    Monitor.Exit(WaitObject);
   }
  }
 }

 public static void ProcessImage(byte[] pixels, int imageNum)
 {
  //Console.WriteLine("ProcessImage "+imageNum);
  // Do some CPU-intensive operation on the image.
  for (int i = 0; i < processImageRepeats; i++)
   for (int j = 0; j < numPixels; j++)
    pixels[j] += 1;
  //Console.WriteLine("ProcessImage "+imageNum+" done.");
 }

 public static void ProcessImagesInBulk()
 {
  Console.WriteLine("Processing images... ");
  //int timer = Pf.StartTimer("ProcessImages");
  int timer = Pf.StartTimer("Total Time");
  NumImagesToFinish = numImages;

  AsyncCallback readImageCallback = new AsyncCallback(ReadInImageCallback);
  for (int i = 0; i < numImages; i++)
  {
   ImageStateObject state = new ImageStateObject();
   state.pixels = new byte[numPixels];
   state.imageNum = i;

   // Because very large items are read only once, the buffer 
   // on the file stream can be very small to save memory.
   FileStream fs = new FileStream(ImageBaseName + i + ".tmp", FileMode.Open, FileAccess.Read, FileShare.Read, 1, true);
   fs.BeginRead(state.pixels, 0, numPixels, readImageCallback, state);
  }

  // Ensure all image processing is done.
  // If not, block until all are finished.
  bool mustBlock = false;
  lock (NumImagesMutex)
   if (NumImagesToFinish > 0)
    mustBlock = true;

  if (mustBlock)
  {
   Console.WriteLine("All worker threads are queued... Blocking until they complete. numLeft: " + NumImagesToFinish);
   Monitor.Enter(WaitObject);
   Monitor.Wait(WaitObject);
   Monitor.Exit(WaitObject);
  }

  Pf.StopTimer(timer);
  Pf.OutputStoppedTime();
 }

 public static void Cleanup()
 {
  for (int i = 0; i < numImages; i++)
  {
   File.Delete(ImageBaseName + i + ".tmp");
   File.Delete(ImageBaseName + i + ".done");
  }
 }

 public static void TryToClearDiskCache()
 {
  // Try to force all pending writes to disk, AND to clear the 
  // disk cache of any data.
  byte[] bytes = new byte[100 * (1 << 20)];
  for (int i = 0; i < bytes.Length; i++)
   bytes[i] = 0;
  bytes = null;
  GC.Collect();
  Thread.Sleep(2000);
 }

 public static void Main(String[] args)
 {
  Console.WriteLine("Bulk image processing sample application, using async IO");
  Console.WriteLine("Simulates applying a simple transformation to " + numImages + " \"images\"");
  Console.WriteLine("(ie, Async FileStream & Threadpool benchmark)");
  Console.WriteLine("Warning - this test requires " + (numPixels * numImages * 2) + " bytes of tmp space");

  if (args.Length == 1)
  {
   processImageRepeats = Int32.Parse(args[0]);
   Console.WriteLine("ProcessImage inner loop - " + processImageRepeats);
  }

  MakeImageFiles();
  TryToClearDiskCache();
  ProcessImagesInBulk();
  Cleanup();
 }

 [System.Runtime.InteropServices.DllImport("KERNEL32", SetLastError = true)]
 static extern void FlushFileBuffers(int handle);
}