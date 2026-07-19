// Write a C# Sharp program to find the length of a string without using a library function.

int count = 0;    // 申明技术字符串长度变量

Console.Write("\n\nFind the length of a string:\n");
Console.Write("---------------------------------\n");

Console.WriteLine("Input the string : ");
string? str = Console.ReadLine();
// 使用 foreach 循环便利字符串中的个字符
foreach (var s in str)
{
 count += 1;    // 递增技术所出现的字符
}

Console.WriteLine(count);