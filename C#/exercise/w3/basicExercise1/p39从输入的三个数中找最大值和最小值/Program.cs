// Write a C# program to find the largest and lowest values from three integer values.

int a, b, c, largest, lowest;
largest = 0;
lowest = 0;

Console.Write("Input the first intger: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second  integer: ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third integer: ");
c = Convert.ToInt32(Console.ReadLine());

// 使用 if-elseif-else 条件表达式
if (a >= b && a >= c)
 largest = a;
else if (b >= a && b >= c)
 largest = b;
else
 largest = c;

if (a <= b && a <= c)
 lowest = a;
else if (b <= a && b <=  c)
 lowest = b;
else
 lowest = c;

Console.WriteLine($"Largest of three: {largest}");
Console.WriteLine($"lowest of three: {lowest}");

// 使用 三元运算符
largest = (a > b && a > c) ? a : (b > c ? b : c);
lowest = (a < b && a < c) ? a : (b < c ? b : c);

Console.WriteLine($"{largest}\n{lowest}");

// 使用 Math.Max() 方法和 Math.Min() 方法
Console.WriteLine(Math.Max(a, Math.Max(b, c)));
Console.WriteLine(Math.Min(a, Math.Min(b, c)));