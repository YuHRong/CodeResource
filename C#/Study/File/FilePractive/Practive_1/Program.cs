using System;
using System.IO;

class Program
{
 static void Main()
 {
  string directoryPath = @"E:example";
  string fileName = "Example.txt";
  string filePath = Path.Combine(directoryPath, fileName);

  // 创建新目录
  Directory.CreateDirectory(directoryPath);

  // 创建一个新文件并写入文本
  File.WriteAllText(filePath, "练习文本。\nhello world!\n你好世界！");

  // 读取文本
  string text = File.ReadAllText(filePath);
  Console.WriteLine(text);
 }
}