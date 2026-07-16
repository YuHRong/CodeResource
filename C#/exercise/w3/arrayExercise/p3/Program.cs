// Write a program in C# Sharp to find the sum of all array elements.

int i, n, sum = 0;
int[] element = new int[100];    // 申明大小为 100 的数组元素

Console.Write("\n\nFind sum of all elements of array:\n");
Console.Write("--------------------------------------\n");

Console.Write("Input the number of elements to be stored in the array :");
n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input {n} elements in the array :");

// 循环写入数组并计算数组中存储的元素的和
for (i = 0; i < n; i++)
{
 Console.Write($"element - {i} : ");
 element[n] = Convert.ToInt32(Console.ReadLine());

 sum += element[n];
}

Console.WriteLine("Sum of all elements stored in the array is : {0}", sum);

Console.WriteLine();