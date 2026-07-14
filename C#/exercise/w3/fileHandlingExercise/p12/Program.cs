// Write a program in C# Sharp to create and read the last line of a file.

using System.IO;
using System.Text;

string fileName = @"mytest.txt";
string[] strArray = { "" };    // 申明保存字符串输入的数组
int i, n;    // 申明技术以及保存行数的变量

Console.Write("\n\n Create and read the last line of a file  :\n");
Console.Write("-----------------------------------------------\n");

// 检查文件是否存在
if (File.Exists(fileName))
{
 // 如果文件存在删除文件
 File.Delete(fileName);
}

// 提示输入写入的字符串行数
Console.Write("Input number of lines to with in the file : ");
n = Convert.ToInt32(Console.ReadLine());

// 将输入的行保存在字符串数组中
strArray = new string[n];

// 提示输入字符串
Console.WriteLine($"Input {n} strings below :");

for (i = 0; i < n; i++)
{
 Console.Write($"Input line {i + 1} : ");

 // 读取并写入每一行字符串
 strArray[i] = Console.ReadLine();
}

// 将获取的字符串数组逐行写入wfjm
using (StreamWriter file = new StreamWriter(@"mytest.txt"))
{
 foreach (var line in strArray)
 {
  file.WriteLine(line);
 }
}

// 使用 StreamReader 打开并读取文件
using (StreamReader st = File.OpenText(fileName))
{
 string[] sf = File.ReadAllLines(fileName);

 Console.Write("\n The content of the last line of the file {0} is  :\n", fileName);

 // 检查文件是否存在
 if (File.Exists(fileName))
 {
  // 将文件的最后一行写入控制台
  Console.WriteLine($"{sf[n - 1]}");
 }
 Console.WriteLine();
}