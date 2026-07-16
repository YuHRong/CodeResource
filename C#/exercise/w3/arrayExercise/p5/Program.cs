// Write a C# Sharp program in to count duplicate elements in an array.

int i, j, k = 0;
int n, count = 0;
int[] arr1 = new int[100];
int[] arr2 = new int[100];
int[] arr3 = new int[100];

        Console.Write("\n\nCount total number of duplicate elements in an array:\n");
        Console.Write("---------------------------------------------------------\n");

Console.Write("Input the number of elements to be stored in the array :");
n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input {n} element in the array : ");

// 循环读取写入的数组元素
for (i = 0; i < n; i++)
{
 Console.Write($"element - {i} : ");
 arr1[i] = Convert.ToInt32(Console.ReadLine());
}

// 将 arr1 的元素复制给 arr2并初始化 arr3 为 0
for (i = 0; i < n; i++)
{
 arr2[i] = arr1[i];
 arr3[i] = 0;
}

// 标记 arr3 中重复的元素
for (i = 0; i < n; i++)
{
 for (j = 0; j < n; j++)
 {
  if (arr1[i] == arr2[j])
  {
   arr3[j] = k;    // 用 k 标记 arr3 中重复的元素
   k++;    // 递增 k
  }
 }
 k = 1;    // 将 k 重置为 1
}

// 统计 arr3 中 重复的元素数量
for (i = 0; i < n; i++)
{
 if (arr3[i] == 2)
 {
  count++;    // 为arr3 中发现的重复元素递增 count
 }
}

// 输出重复元素的技数
Console.WriteLine($"The number of duplicate elements is: {count} \n");

Console.WriteLine();