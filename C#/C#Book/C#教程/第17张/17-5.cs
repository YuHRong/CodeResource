using System;
using System.IO;

class FileTest
{
 public static void Main()
 {
  StreamReader srd;
  try
  {
   srd = File.OpenText("c:\\c#\\file1\\file1.txt");
  }
  catch
  {
   Console.WriteLine("File open failed");
   return;
  }

  while (srd.Peek() != -1)
  {
   String str = srd.ReadLine();
   Console.WriteLine(str);
  }

  Console.WriteLine("The end of the file has been reached");
  srd.Close();
 }
}