// Write a program in C# Sharp to create a file and add some text.

using System.IO;
using System.Text;

string fileName = $"mytext.txt";

try
{

 //创建StreamWriter以将文本写入文件
 using (StreamWriter writer = File.CreateText(fileName))
 {
  // 将内容写入文件
  writer.WriteLine(" Hello and Welcome");
  writer.WriteLine(" It is the first content");
  writer.WriteLine(" of the text file mytest.txt");
  Console.WriteLine(" A file created with content name mytest.txt\n\n"); // Displaying a message indicating successful file creation with content
 }

}
catch (Exception MyExcep)
{
 Console.WriteLine(MyExcep.ToString());
 {

 }
}