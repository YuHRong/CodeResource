using System;
using System.IO;

class DirectoryTest
{
 public static void Main()
 {
  DirectoryInfo d = new DirectoryInfo("c:\\c#");
  DirectoryInfo d1;
  DirectoryInfo d2;

  try
  {
   d1 = d.CreateSubdirectory("file1");
  }
  catch (IOException e)
  {
   Console.WriteLine("directory file1 failed because: {0}", e);
   return;
  }

  try
  {
   d2 = d1.CreateSubdirectory("file2");  //等于 d2 = d1.CreateSubDirectory("file2");
  }
  catch (IOException e)
  {
   Console.WriteLine("directory file2 failed because: {0}", e);
   return;
  }

  Console.WriteLine("Create directory successfully!");
 }
}