// Write a C# program that checks the nearest value of 20 of two given integers and return 0 if two numbers are same.

int x, y;
int r = 20;

Console.Write("Input the first integer: ");
x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second integer: ");
y = Convert.ToInt32(Console.ReadLine());

// 计算 x 到 r 的绝对差值存储在 n1 中
var n1 = Math.Abs(x - r);

// 计算 y 到 r 的绝对差值存储在 n2 中
var n2 = Math.Abs(y - r);

// 如果 n1 等于 n2，则输出0，否则输出 x 和 y 中更接近 r 的数字
Console.WriteLine(n1 == n2 ? 0:  (n1 < n2 ? x : y));

