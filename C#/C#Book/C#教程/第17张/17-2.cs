using System;
using System.IO;

class DirectoryTest
{
 public static void Main()
 {
  DirectoryInfo d = new DirectoryInfo("c:\\c#\\file1");
  DirectoryInfo[] subdir;

  try
  {
   subdir = d.GetDirectories();
  }
  catch (DirectoryNotFoundException e)
  {
   Console.WriteLine("Can not find such a directory because: {0}", e);
   return;
  }

  foreach (DirectoryInfo dir in subdir)
  {
   dir.Delete();
  }

  d.Delete();
  Console.WriteLine("Delete successfully!");
 }
}