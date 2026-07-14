
using System.IO;
using System.Text;

string fileName1 = @"mytest.txt";
string fileName2 = @"mynewtest.txt";

// 检查两个文件是否存在，若两个文件存在则将其删除
if (File.Exists(fileName1))
{
 File.Delete(fileName1);
}

if (File.Exists(fileName2))
{
 File.Delete(fileName2);
}

// Displaying a message to create a file and move it to another name in the same folder
Console.Write("\n\n Create a file and move the file in the same folder to another name  :\n");
Console.Write("----------------------------------------------------------------------\n");

// 创建源文件并写入文本
using (StreamWriter file1 = File.CreateText(fileName1))
{
 file1.WriteLine(" Hello and Welcome");
 file1.WriteLine(" It is the first content");
 file1.WriteLine(" of the text file mytest.txt");
}

//显示源文件内容
using (StreamReader st = File.OpenText(fileName1))
{
 string s = "";

 Console.WriteLine(" Here is the content of the file {0} : ", fileName1);

 while ((s = st.ReadLine()) != null)
 {
  Console.WriteLine(s);
 }
 Console.WriteLine("");
}

// 移动源文件并修改文件名
File.Move(fileName1, fileName2);

// 显示文件移动成功的消息
Console.WriteLine(" The file {0} successfully moved to the name {1} in the same directory.", fileName1, fileName2);

// 像复制的文本写入内容
/*
using (StreamWriter sr = File.CreateText(fileName2))
{
 sr.WriteLine("这是复制后的文本内容");
}*/

// 读取目标文件内容
using (StreamReader file2 = File.OpenText(fileName2))
{
 string s = "";

 Console.WriteLine(" Here is the content of the file {0} : ", fileName2);

// 逐行读取目标文件内容直到文件末尾
 while ((s = file2.ReadLine()) != null)
 {
  Console.WriteLine(s);
 }
 Console.WriteLine();
}

// 等待案件退出
Console.ReadKey();