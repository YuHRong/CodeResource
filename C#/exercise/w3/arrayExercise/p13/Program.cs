// Write a C# Sharp program to insert an additional value into an array (sorted list).

const int len = 100;
int[] arr = new int[len];
int n, value, i, j;

Console.Write("\n\nInsert an additional value into an array (sorted list) :\n");
Console.WriteLine("---------------------------------------------------------\n");

Console.Write("Input the size of array : ");
n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input {n} elements in the array in ascending order :");
for (i = 0; i < n; i++)
{
 Console.Write($"element - {i} : ");
 arr[i] = Convert.ToInt32(Console.ReadLine());
}

        Console.Write("Input the value to be inserted : ");
value = Convert.ToInt32(Console.ReadLine());

// 打印原数组
        Console.WriteLine("The existing array list is :\n ");
for (i = 0; i < n; i++)
{
 Console.Write($"{arr[i]} ");
}
Console.WriteLine();

// 确定插入新值的位置
for (i = 0; i < n; i++)
{
 if (value < arr[i])
 {
  // 将元素向后移动一位
  for (j = n; j > i; j--)
  {
   arr[j] = arr[j - 1];
  }
  // 插入新元素
  arr[i] = value;
  break;
 }
}

// 如果新值大于所有元素，则将其插入到数组末尾
if (i == n)
{
 arr[n] = value;
}

// 打印插入新值后的数组
        Console.WriteLine("\n\nAfter Insert, the list is :\n ");
for (i = 0; i <= n; i++)
{
 Console.Write($"{arr[i]} ");
}
Console.WriteLine();