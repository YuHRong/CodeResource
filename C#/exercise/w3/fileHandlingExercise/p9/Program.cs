// Write a program in C# Sharp to create and copy the file to another name and display the content.

using System.IO;
using System.Text;

string fileName1 = @"mytest.txt";
string fileName2 = @"mynewtest.txt";

if (File.Exists(fileName1))
{
 File.Delete(fileName1);
}

if (File.Exists(fileName2))
{
 File.Delete(fileName2);
}

Console.Write("\n\n Create a file and copy the file  :\n");
Console.Write("---------------------------------------\n");

// 创建源文件并将初始内容写入其中。
using (StreamWriter file = File.CreateText(fileName1))
{
 //将初始内容写入源文件
 file.WriteLine(" Hello and Welcome");
 file.WriteLine(" It is the first content");
 file.WriteLine(" of the text file mytest.txt");
}

// 显示源文件内容
// 读取原始文本
using (StreamReader sr = File.OpenText(fileName1))
{
 string s = "";

 Console.WriteLine(" Here is the content of the file {0} : ", fileName1);

 while ((s = sr.ReadLine()) != null)
 {
  Console.WriteLine(s);
 }

 Console.WriteLine();
}

// 将源文件复制到目标文件
File.Copy(fileName1, fileName2, true);

// 显示复制成功消息
Console.WriteLine(" The file {0} successfully copied to the name {1} in the same directory.", fileName1, fileName2);


/*
// 像复制的文本写入内容
using (StreamWriter file = File.CreateText(fileName2))
{
 file.WriteLine("这是复制后写入的文本");
}*/

// 读取第二份文本
// 显示目标文件的内容
using (StreamReader st = File.OpenText(fileName2))
{
 string s = "";

 Console.WriteLine(" Here is the content of the file {0} : ", fileName2);

// 逐行读取文件，直到文件尾
 while ((s = st.ReadLine()) != null)
 {
  // 逐行显示文件内容
  Console.WriteLine(s);
 }
 Console.WriteLine();
}

// 等待案件退出
Console.ReadKey();