// Write a C# program to check if a given positive number is a multiple of 3 or 7.

int n;

Console.WriteLine("Input first integer:");
n = Convert.ToInt32(Console.ReadLine());

// 检查输入是否大于0
if (n > 0)
{
 // 如果输入大于 0，使用取模运算符计算结果是否为 0
 Console.WriteLine(n % 3 == 0 || n % 7 == 0);
}
