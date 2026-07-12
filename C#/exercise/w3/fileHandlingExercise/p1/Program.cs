// Write a program in C# Sharp to create a blank file on the disk.

using System.IO;
using System.Text;

// 使用文件名初始化字符串变量
string filename = $"mytest.txt";

try
{
  // 查找文件是否存在
  if (File.Exists(filename))
  {
    // 如果文件删除文件
    File.Delete(filename);
  }

  // 在控制台中打印消息
  Console.WriteLine("\n\n Create a file named mytest.txt in the disk :\n");

  // 打印分隔线
  Console.Write("------------------------------------------------\n");

  // 创建文件
  // 创建FileStream以创建文件
  using (FileStream fileStr = File.Create(filename))
  {
    // 显示文件创建成功的消息
    Console.WriteLine(" A file created with name mytest.txt\n\n");
  }
}
catch (Exception MyExcep)
{  //捕捉可能发生的任何异常
// 打印错误提示（如果有）
  Console.WriteLine(MyExcep.ToString());
}