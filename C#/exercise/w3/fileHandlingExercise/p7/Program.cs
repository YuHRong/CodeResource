// Write a C# Sharp program to create and write some lines of text into a file. This does not contain a given string on a line.

using System.IO;
using System.Text;

// 以文件名初始化变量
string fileName = $"mytest.txt";

// 申明一个字符串数组变量存储文本
string[] strLines;
// 申明保存排除字符串的变量
string str;

// 申明记录行和迭代的变量
int n, i;

// 显示消息
Console.Write("\n\n Create and write some line of text which does not contain a given string in a line  :\n");
Console.Write("------------------------------------------------------------------------------------------\n");

// 检查文件是否存在，若文件存在删除文件
if (File.Exists(fileName))
{
 File.Delete(fileName);
}

// 询问输入需要排除的字符串
Console.Write("\nInput the string to ignore the line : ");
// 获取需要排除的字符串
str = Console.ReadLine();

// 提示输入行数
Console.WriteLine("Input number of lines to write in the file  : ");
// 获取行数
n = Convert.ToInt32(Console.ReadLine());

// 使用获取到的行数初始化字符串数组
strLines = new string[n];

// 提示输入文本行
Console.WriteLine($"Input {n} strings below :\n");

//根据定义的计数循环输入文本行
for (i = 0; i < n; i++)
{
 Console.Write($"Input line {i + 1}");

 // 读取并写入每一行数组字符串
 strLines[i] = Console.ReadLine();
}

// 将行写入文件，不包括包含要忽略的给定字符串的行
using (System.IO.StreamWriter file = new StreamWriter(@"mytest.txt"))
{
 foreach (string line in strLines)
 {
  // 如果该行不包含排除的字符串，将他写入文件
  if (!line.Contains(str))
  {
   file.WriteLine(line);
  }
 }
}

// 使用 StreamReader 打开文件并读取文件
using (StreamReader st = File.OpenText(fileName))
{
 string s = "";

 // 显示忽略行的消息
 Console.Write($"\nThe line has been ignored if it contains the string '{str}'. \n");
 Console.Write("----------------------------------\n");

 // 读取并显示文件的每一行
 while ((s = st.ReadLine()) != null)
 {
  // 显示文本内容
  Console.WriteLine(s);
 }
}
