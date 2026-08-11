// Write a C# Sharp program to merge two arrays of the same size sorted in ascending order.

using System;

class Program
{
 static void Main()
 {
  // 申明三个 int 类型数组
  int[] arr1 = new int[100];
  int[] arr2 = new int[100];
  int[] arr3 = new int[200];

  int n1, n2, n3;    // 申明三个输入数组长度的数组
  int i;

  // 询问第一个数组长度
  Console.Write("Input the number of elements to be stored in the first array :");
  n1 = Convert.ToInt32(Console.ReadLine());

  // 循环便利写入第一个数组元素
  Console.WriteLine("Input {0} elements in the array :", n1);
  for (i = 0; i < n1; i++)
  {
   Console.Write("element - {0}", i);
   arr1[i] = Convert.ToInt32(Console.ReadLine());
  }

  // 询问第二个数组长度
  Console.WriteLine("Input the number of elements to be stored in the second array :");
  n2 = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("Input {0} elements in the array:", n2);
  for (i = 0; i < n2; i++)
  {
   Console.Write("element - {0}", i);
   arr2[i] = Convert.ToInt32(Console.ReadLine());
  }

  // 计算第三个数组的长度
  n3 = n1 + n2;

  // 将 arr1 数组和 arr2 复制给 arr3
  for (i = 0; i < n1; i++)
   arr3[i] = arr1[i];

  for (int j = 0; j < n2; j++)
  {
   arr3[i] = arr2[j];
   i++;    // 将 arr2 数组元素追加到 arr3 数组中
  }

  // 调用冒泡排序方法进行排序
  SortOrderArray(arr3, n3);

  // 打印排序后的数组
  Console.Write("\nThe merged array in ascending order is :\n");
  for (i = 0; i < n3; i++)
  {
   Console.WriteLine(arr3[i] + " ");
  }
 }

 /// <summary>
 /// 使用冒泡排序排序当前数组，
 /// 当前一个元素大于或等于当前元素时，使用中间变量将当前元素的值与前一个元素交换位置。
 /// SortOrderArray,
 /// "arr" 传入的数组名称， "size" 传入的数组长度
 /// </summary>
 static void SortOrderArray(int[] arr, int size)
 {
  for (int i = 0; i < size; i++)
  {
   for (int j = 0; j < size - 1; j++)
   {
    if (arr[j] >= arr[j + 1])
    {
     int t = arr[j + 1];
     arr[j + 1] = arr[j];
     arr[j] = t;
    }
   }
  }
 }
}
