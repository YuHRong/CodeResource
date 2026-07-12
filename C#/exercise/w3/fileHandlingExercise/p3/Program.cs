// Write a C# Sharp program to create a blank file on the disk if the same file already exists.

using System.IO;
using System.Text;

string fileName = $"mytest.txt";

try
{
 // 检查文件是否存在
 if (File.Exists(fileName))
 {
  // 如果文件存在将其删除
  File.Delete(fileName);
  {
   Console.WriteLine("A file created with name mytest.txt");
  }

  //显示一条消息以在磁盘中创建文件（如果存在）
  Console.Write("\n\n Create a file in the disk if it exists:\n");
  Console.Write("-----------------------------------------------\n");

  // 创建文件
  // 使用 FileStream 创建文件
  using (FileStream fileStr = File.Create(fileName))
  {
   //显示指示文件创建成功的消息
   Console.WriteLine(" A file created with name mytest.txt\n\n");
  }
 }
}
catch (Exception ex)
{    // 捕捉可能触发的异常
 Console.WriteLine("文件创建失败。" + ex.ToString());
}