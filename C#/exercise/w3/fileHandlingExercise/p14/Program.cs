//   Write a C# Sharp program to create and read the last n lines of a file.

using System.IO;
using System.Text;

string fileName = @"mytest.txt";    // 初始化文件名称变量
int n;    // 申明获取输入行的变量
string[] strArray;   // 申明字符串数组变量，


Console.Write("\n\n Read last n number of lines from a file  :\n");
Console.Write("-----------------------------------------------\n");

if (File.Exists(fileName))
{
 File.Delete(fileName);
}

Console.Write("Input number of lines to write in the file : ");   // 提示输入行数
n = Convert.ToInt32(Console.ReadLine());    // 读取输入行数

// 初始化数组以存储行
strArray = new string[n];

Console.WriteLine("Input {0} strings below : ", n);

for (int i = 0; i < n; i++)
{
 Console.Write($"Input line {i + 1}");

 // 从输入中读取文本行
 strArray[i] = Console.ReadLine();
}

// 将读取的行写入文件
File.WriteAllLines(fileName, strArray);

// 读取文档
using (StreamReader file = File.OpenText(fileName))
{
 string s = "";

 while ((s = file.ReadLine()) != null)
 {
  Console.WriteLine(s);
 }

 Console.WriteLine();
}

// 提示输入最后要显示的行数
Console.Write(" Input last how many numbers of lines you want to display  :");
int j = Convert.ToInt32(Console.ReadLine());    // 读取输入最后显示的行数

// 检查指定的行数是否在有效范围内
if (j >= 1 && j <= n)
{
 Console.WriteLine("The content of the last {0} lines of the file {1} :\n", j, fileName);

 string[] lines = File.ReadAllLines(fileName);

 if (File.Exists(fileName))    // 检查文件是否存在
 {
  for (int i = n - j; i < n; i++)
  {    // 循环读取最后的 j 行
   Console.Write("The last noe {0} line is : ", j--);
   Console.WriteLine(lines[i]);
  }
 }
}
else
{
 Console.WriteLine(" Please input the correct number of lines."); // Displaying message for incorrect line number input
}

Console.WriteLine();

// 等待案件退出
Console.ReadKey();