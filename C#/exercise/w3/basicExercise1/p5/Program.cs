// 5. Swap Two Numbers
// Write a C# Sharp program to swap two numbers.
// 使用中间变量进行交换

int num1, num2, temp = 0;

Console.WriteLine("Input the first number: ");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number: ");
num2 = int.Parse(Console.ReadLine());

temp = num1;
num1 = num2;
num2 = temp;

Console.WriteLine("After Swapping :\n");
Console.WriteLine($"First Number : {num1}");
Console.WriteLine($"Second Number : {num2}");
