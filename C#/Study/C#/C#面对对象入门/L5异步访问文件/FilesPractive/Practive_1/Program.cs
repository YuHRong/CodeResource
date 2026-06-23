using System;
using System.IO;

class Program
{
 static void Main()
 {
  // 申明目录变量
  string directoryPath = @"E:ExampleDirectory";
  // 申明文件名称变量
  string fileName = "Example.txt";
  // 将目录与文件连接
  string filePath = Path.Combine(directoryPath, fileName);

  // 创建新目录
  Directory.CreateDirectory(directoryPath);

  // 检查目录是否存在
  if (!Directory.Exists(filePath))
  {
   Directory.CreateDirectory(filePath);
  }

  // 写入文件
  using (StreamWriter writer  = new StreamWriter(filePath, true))
  {
   Console.ReadLine();
  }

  string dataPath = "ExampleDirectory";
  string oFileName = "Example.txt";

  Console.WriteLine(fileName);
 }
}
