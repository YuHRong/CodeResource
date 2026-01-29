using System;
using System.IO;

class FileTest
{
 public static void Main(String[] args)
 {
  // 验证参数输入是否正确
  string sourcename;
  string targetname;

  try
  {
   sourcename = args[0];
  }
  catch
  {
   Console.WriteLine("Please input the name of the source file correctly");
   return;
  }

  try
  {
   targetname = args[1];
  }
  catch
  {
   Console.WriteLine("Please input the name of the target file correctly");
   return;
  }

  // 进行文件拷贝操作
  File file;
  try
  {
   file = new File(sourcename);
  }
  catch
  {
   Console.WriteLine("Can not open the source file named '{0}'", sourcename);
   return;
  }

  try
  {
   file.CopyTo(targetname, true);
  }
  catch
  {
   Console.WriteLine("Can write the target file named '{0}'", targetname);
   return;
  }

  Console.WriteLine("File copys successfully!");
 }
}