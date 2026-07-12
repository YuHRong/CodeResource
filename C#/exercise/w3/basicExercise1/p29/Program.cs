// File Size in Bytes
// Write a C# program to find the size of a specified file in bytes.
using System.IO;


//创建一个代表指定路径下文件的FileInfo对象
FileInfo file = new FileInfo($"E:\\2\\1.7z");

//使用FileInfo的Length属性显示文件的大小（以字节为单位）
Console.WriteLine($"\nSize of a file: {file.Length.ToString()}");