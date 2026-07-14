// Write a program in C# Sharp to append some text to an existing file.

using System.IO;
using System.Text;

string fileName = $"mytest.txt";

try
{
 // 检查并删除 mytest.txt 文件
 if (File.Exists(fileName))
 {
  // 删除文件
  File.Delete(fileName);
 }

 Console.Write("\n\n Append some text to an existing file  :\n");
 Console.Write("--------------------------------------------\n");

 // 写入初始文本
 using (StreamWriter fileStr = File.CreateText(fileName))
 {
  fileStr.WriteLine("Here is the content of the file mytest.txt : ");
  fileStr.WriteLine("Hello  and Welcome");
  fileStr.WriteLine("It is the first content");
  fileStr.WriteLine("of the text file mytest.txt");
 }

 // 在附加文本之前读取
 // 使用 StreamReader 类打开并读取
 using (StreamReader sr = File.OpenText(fileName))
 {
  string s = "";

  Console.WriteLine("Here is the content of the file mytest.txt : ");

  // 便利每一行直到文件末尾
  while ((s = sr.ReadLine()) != null)
  {
   // 打印每一行
   Console.WriteLine(s);
   Console.WriteLine();
  }
 }

 // 在文件末尾附加一行， true 
 //使用StreamWriter附加到现有文件
 using (StreamWriter file = new StreamWriter(@"mytest.txt"))
 {
  // 向文件追加一行
  file.WriteLine(" This is the line appended at the last line."); // Appending a line to the file
 }

 // 追加后读取并显示文件内容
 // 再次打开StreamReader以读取文件的更新内容
 using (StreamReader sr = File.OpenText(fileName))
 {
  string s = "";

  Console.WriteLine(" Here is the content of the file after appending the text : ");

  // 逐行读取文件内容直到文件末尾
  while ((s = sr.ReadLine()) != null)
  {
   Console.WriteLine(s);
   Console.WriteLine();
  }
 }

}
catch (Exception MyExecp)
{
 // 显示异常信息
 Console.WriteLine(MyExecp.ToString());
}