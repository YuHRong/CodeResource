
using System.IO;
using System.Text;

string fileName = @"mytest.txt";
int count = 0;   // 初始化计数变量为0

if (File.Exists(fileName))
{
 File.Delete(fileName);
}

Console.Write("\n\n Count the number of lines in a file :\n");
Console.Write("------------------------------------------\n");

// 将文本写入文件
using (StreamWriter file = File.CreateText(fileName))
{
 file.WriteLine("line 1");
 file.WriteLine("line 2");
 file.WriteLine("line 3");
 file.WriteLine("line 4");
 file.WriteLine("line 5");
 file.WriteLine("line 6");
}

// 使用 StreamReader 打开文件并读取
using (StreamReader sr = File.OpenText(fileName))
{
 string s = "";

 Console.WriteLine($"Here is the content of the file {fileName} : ");

 // 逐行读取文件内容
 while ((s = sr.ReadLine()) != null)
 {

  Console.WriteLine(s);
  count++;
 }
 // 显示文件的行数
 Console.WriteLine($"The number of lines in  the file {fileName} is : {count}");

 Console.WriteLine();
}

/*
// 将文件存入 lines 字符串数组
string[] lines = File.ReadAllLines(fileName);
int count = 0;

// 便利访问数组元素
for (int i = 0; i < lines.Length; i++)
{
 count++;
}
Console.WriteLine($"The number of lines in  the file {fileName} is : {count}");
*/

// 等待案件关闭
Console.ReadKey();