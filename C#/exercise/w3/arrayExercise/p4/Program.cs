// Write a C# Sharp program to copy the elements of one array into another array.

int i, n;
int[] element1 = new int[100];
int[] element2 = new int[100];

Console.Write("\n\nCopy the elements from one array into another array:\n");
Console.Write("------------------------------------------------------\n");

Console.Write("Input the number of elements to be stored in the array :");
n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input {n} elements in the array :");

// 循环写入第一个数组元素
for (i = 0; i < n; i++)
{
 Console.Write($"element - {i}");
 element1[i] = Convert.ToInt32(Console.ReadLine());
}

// 复制数组元素的值
for (i = 0; i < n; i++)
{
 element2[i] = element1[i];
}

// 显示第一个 element1 元素
Console.WriteLine("The elements stored in the first array are :");
// 循环打印元素数组的值
for (i = 0; i < n; i++)
{
 Console.Write($"{element1[i]} ");
}
Console.WriteLine();

// 显示复制后的 element2 元素
Console.WriteLine($"The elements copied into the second array are :");

// 循环打印
for (i = 0; i < n; i++)
{
 Console.Write($"{element2[i]} ");
}

Console.WriteLine();