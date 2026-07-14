// Write a C# Sharp program to read the first line of a file.

using System.IO;
using System.Text;

string fileName = @"mytest.txt";

try
{
 // 检查文件是否存在
 if (File.Exists(fileName))
 {
  // 如果文件存在删除文件
  File.Delete(fileName);
 }

 Console.Write("\n\n Read the first line from a file  :\n");
 Console.Write("---------------------------------------\n");

 // 创建文件并像文件写入内容
 using (StreamWriter sr = File.CreateText(fileName))
 {
  sr.WriteLine("test line 1");
  sr.WriteLine("test line 2");
  sr.WriteLine("test line 3");
 }

 // 打印源文件内容
 using (StreamReader st = File.OpenText(fileName))
 {
  string s = "";

  Console.WriteLine("Here is the content of the file mytest.txt :");

  while ((s = st.ReadLine()) != null)
  {
   Console.WriteLine(s);
  }

  Console.WriteLine();
 }

 // 打印第一行
 using (StreamReader st = File.OpenText(fileName))
 {
  string s = "";

  Console.WriteLine("The content of the first line of the file is : ");

  // 检查文件是否存在
  if (File.Exists(fileName))
  {
   //从文件中读取所有行
   string[] lines = File.ReadAllLines(fileName);

   // 将文件的第一行写入控制台
   Console.WriteLine(lines[0]);
  }

  Console.WriteLine();
 }
}
catch (Exception MyExcep)
{
 Console.WriteLine(MyExcep.ToString());
}