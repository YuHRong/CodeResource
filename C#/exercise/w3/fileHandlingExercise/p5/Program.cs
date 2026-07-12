// Write a C# Sharp program to create a text file and read it.

using System.IO;
using System.Text;

string fileName = $"mytest.txt";

try
{
 // 检查文件
 if (File.Exists(fileName))
 {
  // 如果文件存在删除文件
  File.Delete(fileName);
 }

 Console.Write("\n\n Create a file with text and read the file  :\n");
 Console.Write("-------------------------------------------------\n");

 // 创建文件并写入文本
 // 使用 StreamWriter 类 写入文件
 using (StreamWriter fileStr = File.CreateText(fileName))
 {
  // 将内容写入文件
  fileStr.WriteLine("Hello and Welcome");
  fileStr.WriteLine(" It is the first content");
  fileStr.WriteLine(" of the text file mytest.txt");
 }

 // 创建StreamReader以从文件中读取文本
 using (StreamReader rF = File.OpenText(fileName))
 {
  string line = "";

  Console.WriteLine("Here is the content of the file mytest.txt : ");

  //从文件中读取和显示内容
  while ((line = rF.ReadLine()) != null)
  {
   // 逐行读取直到末尾}

   // 显示美一行
   Console.WriteLine(line);

   // 添加空行格式化
   Console.WriteLine("");
  }

  /*
    string[] lines = File.ReadAllLines(fileName);
    Console.WriteLine("Here is the content of the file mytest.txt : ");
    foreach (var line in lines)
    {
    Console.WriteLine(line);
    }
   */
 }

}
catch (Exception MyExcep)
{
 Console.WriteLine(MyExcep.ToString());
}