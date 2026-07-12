// Write a program in C# Sharp to create a file and write an array of strings to the file.

using System.IO;
using System.Text;

// 使用文件名初始化字符串变量
string fileName = $"mytest.txt";

// 申明一个字符串数组变量存储行
string[] strLines;

// 申明用于技术行和迭代的变量
int i, n;

// 打印信息后打印分割线
Console.Write("\n\n Create a file and write an array of strings  :\n");
Console.Write("---------------------------------------------------\n");

// 检查已存在的文件并删除
if (File.Exists(fileName))
{
 // 删除文件
 File.Delete(fileName);
}

// 提示输入需要写入文件的行数
Console.WriteLine("Input number of lines to woite in the file  :");
n = Convert.ToInt32(Console.ReadLine());

// 使用提供的行数初始化字符串数组
strLines = new string[n];

// 提示输入文本行
Console.WriteLine($"Input {n} strings below :");

// 根据定义的技术循环输入文本行
for (i = 0; i < n; i++)
{
 //每行提示
 Console.WriteLine($"I nput line {i + 1} : ");

 // 读取并写入每一行文本 // 
 strLines[i] = Console.ReadLine();
}

// 将数组中的所有行写入文件
File.WriteAllLines(fileName, strLines);

// 读取并显示内容
// 打开StreamReader 读取文件内容
using (StreamReader str = File.OpenText(fileName))
{
 string lin = "";

 Console.WriteLine("The content of the file is   :");
 Console.Write("----------------------------------\n");

 // 读取并显示文件的每一行
 while ((lin = str.ReadLine()) != null)
 {  // 循环遍历每一行，直到文件末尾
    // 在控制台中逐行显示
  Console.WriteLine($"{lin}");
  Console.WriteLine();
 }
}