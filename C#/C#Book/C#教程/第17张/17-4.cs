using System;
using System.IO;

class FileTest
{
 public static void Main()
 {
  Console.WriteLine("Are you sure to delete all the files in current directory?");
  Console.WriteLine("Press 'Y' then enter to continue, any other key to abort");

  int a = Console.Read();

  if (a == 'Y' || a == 'y')
  {
   Console.WriteLine("Deleting the files...");
  }
  else
  {
   Console.WriteLine("canceled by user");
   return;
  }

  Directory dir = new Directory(".");
  foreach (File f in dir.GetFiles())
  {
   f.Delete();
  }
 }
}