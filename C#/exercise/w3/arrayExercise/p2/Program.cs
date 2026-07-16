// Write a C# Sharp program to read n values in an array and display them in reverse order.

int i, n;  // 申明输入元素数量的变量，输入循环变量 i
int[] element;    // 申明元素数组

Console.Write("\n\nRead n number of values in an array and display it in reverse order:\n");
Console.Write("------------------------------------------------------------------------\n");

Console.Write("\nInput the number of elements to store in the array :");
n = Convert.ToInt32(Console.ReadLine());

// 将输入的值存储在元素数组中
element = new int[n];

Console.WriteLine($"Input {n} number of elements in the array :");

// 循环写入数组元素
for (i = 0; i < n; i++)
{
 Console.Write($"element {i + 1}");
 element[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("The values store into the array are:");

// 循环打印数组的值
for (i = 0; i < n; i++)
{
 Console.Write($"{element[i]} ");
}

Console.Write("\nThe values store into the array in reverse are :\n");

// 倒叙打印数组的值
for (i = n - 1; i >= 0; i--)
{
 Console.Write($"{element[i]} ");
}

Console.WriteLine("\n");