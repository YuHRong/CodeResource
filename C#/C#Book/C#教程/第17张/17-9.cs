using BenchUtil;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

public class BulkImageProcSync
{
 public const String ImageBaseName = "tmpImage-";
 public const int numImages = 200;
 public const int numPixels = 512 * 512;

 // ProcessImage has a simple O(N) loop, and we can vary the number
 // of times we repeat that loop to make the app more CPU-bound or
 // more IO-bound.
 public static int processImageRepeats = 20;
 internal static PerfTimer Pf = new PerfTimer("Synchronous Bulk Image Processor");

 public static void MakeImageFiles()
 {
  int sides = (int)Math.Sqrt(numPixels);
  Console.Write("Making " + numImages + " " + sides + "x" + sides + " images... ");
  byte[] pixels = new byte[numPixels];

  for (int i = 0; i < numPixels; i++)
   pixels[i] = (byte)i;

  for (int i = 0; i < numImages; i++)
  {
   FileStream fs = new FileStream(ImageBaseName + i + ".tmp", FileMode.Create,
   FileAccess.Write, FileShare.None, 8192, false);
   fs.Write(pixels, 0, pixels.Length);
   FlushFileBuffers(fs.GetHandle());
   fs.Close();
  }
  Console.WriteLine("Done.");
 }

 public static void ProcessImage(byte[] pixels, int imageNum)
 {
  //Console.WriteLine("ProcessImage "+imageNum);
  // Do some CPU-intensive operation on the image
  for (int i = 0; i < processImageRepeats; i++)
   for (int j = 0; j < numPixels; j++)
    pixels[j] += 1;
  //Console.WriteLine("ProcessImage "+imageNum+" //done.");
 }

 public static void ProcessImagesInBulk()
 {
  Console.WriteLine("Processing images... ");
  int timer = Pf.StartTimer("Total Time");
  byte[] pixels = new byte[numPixels];

  for (int i = 0; i < numImages; i++)
  {
   FileStream input = new FileStream(ImageBaseName + i + ".tmp",
   FileMode.Open, FileAccess.Read, FileShare.Read, 4196, false);
   input.Read(pixels, 0, numPixels);
   input.Close();
   ProcessImage(pixels, i);

   FileStream output = new FileStream(ImageBaseName + i +
   ".done", FileMode.Create, FileAccess.Write,
   FileShare.None, 4196, false);
   output.Write(pixels, 0, numPixels);
   output.Close();
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
  byte[] bytes = new byte[100 * (1 << 20)];
  for (int i = 0; i < bytes.Length; i++)
   bytes[i] = 0;
  bytes = null;
  GC.Collect();
  Thread.Sleep(2000);
 }

 public static void Main(String[] args)
 {
  Console.WriteLine("Bulk image processing sample application, using synchronous IO");
  Console.WriteLine("Simulates applying a simple transformation to " + numImages + " \"images\"");
  Console.WriteLine("(ie, Sync FileStream benchmark)");
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

 [DllImport("KERNEL32", SetLastError = true)]
 static extern void FlushFileBuffers(int handle);
}