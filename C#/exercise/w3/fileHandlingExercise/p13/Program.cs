// Write a program in C# Sharp to read a specific line from a file.

using System.IO;
using System.Text;

string fileName = @"mytest.txt";  // 申明保存文件名变量
string[] strArray;    // 申明保存字符串数组变量
int i, n;  // 申明循环技术以及行变量

Console.Write("\n\n Read a specific line from a file  :\n");
Console.Write("----------------------------------------\n");

// 检查文件是否存在，如果文件存在将其删除
if (File.Exists(fileName))
{
 File.Delete(fileName);
}

// 询问输入字符串行数
Console.Write("Input number of lines to write in the file  :");
// 读取输入字符串行数
n = Convert.ToInt32(Console.ReadLine());

// 初始化数组存储行
strArray = new string[n];

Console.WriteLine($"\nInput {n} strings below: ");
// 循环读取输入字符串
for (i = 0; i < n; i++)
{
 Console.Write($"Input line {i + 1} : ");
 strArray[i] = Console.ReadLine();
}

// 将获取到的字符串逐行写入文本
File.WriteAllLines(fileName, strArray);

// 显示源文件
using (StreamReader file = File.OpenText(fileName))
{
 string s = "";

 // 逐行显示文件内容
 while ((s = file.ReadLine()) != null)
 {
  Console.WriteLine(s);
 }

 Console.WriteLine();
}

/* // 将文件逐行读取
using (StreamReader sf = File.OpenText(fileName))
{
 string[] line = File.ReadAllLines(fileName);

 // 检查文件
 if (File.Exists(fileName))
 {
  // 询问用户需要查看哪一行
  Console.Write("你需要查看哪一行");
  n = Convert.ToInt32(Console.ReadLine());

  // 打印信息
  Console.WriteLine($"The content of the line {n} of the file mytest.txt is : ");
  Console.WriteLine(line[n - 1]);
 }
 Console.WriteLine();
} */

Console.Write("\n Input which line you want to display  :");
int l = Convert.ToInt32(Console.ReadLine());

// 检查输入的行号是否在范围内
if (l >= 1 && l <= n)
{
 Console.Write("\n The content of the line {0} of the file {1} is : \n", l, fileName);

 // 检查文件
 if (File.Exists(fileName))
 {
  // 读取文件中的所有hh
  string[] lines = File.ReadAllLines(fileName);

  // 将指定行写入控制台
  Console.WriteLine(lines[l - 1]);
 }
}
else
{
 // 显示行号错误消息
 Console.WriteLine(" Please input the correct line number.");
}

Console.WriteLine();