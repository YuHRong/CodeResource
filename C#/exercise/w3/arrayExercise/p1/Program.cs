// Write a C# Sharp program that stores elements in an array and prints them.

int i;
// int[] element = new int[10]; ;    申明大小为 10 的整数数组

Console.Write("\n\nRead and Print elements of an array:\n");
Console.Write("-----------------------------------------\n");

Console.WriteLine("Input 10 elements in the array:");

// 循环读取 10 个元素保存在数组中
for (i = 0; i < 10; i++)
{
 Console.Write("Element {0}", i);
 element[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Elements in array are :");

// 循环打印 10 个数组元素
for (i = 0; i < 10; i++)
{
 Console.Write($"{i} ");
}