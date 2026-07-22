// Sum or Triple Sum of Integers
// Write a C# program to compute the sum of two given integers. If two values are the same, return the triple of their sum.

int num1, num2;

Console.Write("Input first intger: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumTriple(num1, num2));

static int SumTriple(int a, int b)
{
 // 使用三元运算符检查整数 “a” 和 “b” 是否相等
 return a == b ? (a + b) * 3 : a + b;
}