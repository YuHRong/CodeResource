// Repeat Number in Rows
// Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it twice: Use the console. Write and use {0}.

using System.Diagnostics;

int num;

Console.Write("Enter a digit: ");
num = Convert.ToInt32(Console.ReadLine());

// 方案1： 使用 num num num num num {0}打印
Console.Write("{0} {0} {0} {0}", num);
Console.WriteLine();  // 打印换行
// 方案2： 使用 numnumnumnum {0}打印
Console.WriteLine("{0}{0}{0}{0}", num);

// 方案 3： 使用 for 循环
for(int i = 0; i < 4; i++)
{
 Console.Write(num);
 Console.Write(" ");
}
Console.WriteLine();

// 方案 4： 使用字符串内插打印
Console.WriteLine($"{num}{num}{num}{num}");