using System;
using System.IO;

class FileClassifier
{
 public static void ClassifyByExtension(string directoryPath)
 {
  var dir = new DirectoryInfo(directoryPath);

  // 分类获取各类文件
  var wordFiles = dir.GetFiles("*.docx");
  var imageFiles = dir.GetFiles("*.jpg");
  var logFiles = dir.GetFiles("*.log");

  Console.WriteLine($"共找到： {wordFiles.Length} 个 Word 文件");
  foreach(var file in wordFiles)
   Console.WriteLine($" -  {file.Name}");

  Console.WriteLine($"找到： {imageFiles.Length} 个 Jpg 图片");
  foreach(var file in imageFiles)
   Console.WriteLine($"  - {file.Name}");

  Console.WriteLine($"找到： {logFiles} 个日志文件");
  foreach(var file in logFiles)
   Console.WriteLine($"  - {file.Name}");
 }
}