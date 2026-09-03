// Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).


int x, y;

Console.WriteLine("x = y² - 2y + 1");
Console.WriteLine();

//循环以计算和显示不同y值（-5到5）的x
for (y = -5; y < 5; y++)
{
 // 使用方程式x = y² - 2y + 1 计算 x
x = y * y - 2 * y + 1;
Console.WriteLine($"y = {y}; x = ({x})² - 2*({y}) + 1 = {x}");
}