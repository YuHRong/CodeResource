using static System.Console;

namespace ex1;

public static class SortShell
{
 // 执行 shell 排序的方法
 public static void ShellSort(int[] arr, int arraySize)
 {
  int inc = 3;    // Shell 排序的初始值
  while (inc > 0)
  {
   for (int i = 0; i < arraySize; i++)
   {
    int j = i;
    int temp = arr[i];
    while ((j >= inc && arr[j - inc] > temp))
    {
     arr[j] = arr[j - inc];
     j -= inc;
    }
    arr[j] = temp;
   }

   // 更新增量值
   if (inc / 2 != 0)
    inc = inc / 2;
   else if (inc == 1)
    inc = 0;
   else
    inc = 1;
  }
 }

 // 显示数组元素的方法
 public static void ShellArrayElements(int[] arr)
 {
  foreach (var element in arr)
  {
   Write(element + " ");    // 显示数组的每个元素
  }
  WriteLine();    // 显示所有元素后移动到下一行
 }
}
