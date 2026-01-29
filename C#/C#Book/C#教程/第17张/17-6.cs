using System;
using System.IO;

class FileTest
{
 public static void Main()
 {
  StreamWriter srd;
  try
  {
   srd = File.CreateText("c:\\c#\\file1\\file2.txt");
  }
  catch
  {
   Console.WriteLine("File create failed");
   return;
  }

  srd.WriteLine("Web Address:");
  srd.WriteLine("www.sohu.com");
  srd.WriteLine("www.263.net");
  srd.WriteLine("www.microsoft.com/china");
  srd.WriteLine("www.sina.com.cn");
  srd.Close();
 }
}