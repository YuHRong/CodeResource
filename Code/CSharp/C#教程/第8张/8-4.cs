using System;
class Test
{
 public static void Main()
 {
  int[,] a = new int[5, 5];
  a[0, 0] = 1;

  for (int i = 1; i < 5; i++) // 改为 i < 5
  {
   a[i, 0] = 1;
   a[i, i] = 1;
   for (int j = 1; j < i; j++) // 改为 j < i
   {
    a[i, j] = a[i - 1, j - 1] + a[i - 1, j];
   }
  }

  for (int i = 0; i < 5; i++) // 改为 i < 5
  {
   for (int j = 0; j <= i; j++) // 改为 j <= i
   {
    Console.Write("{0} ", a[i, j]); // 修正语法错误
   }
   Console.WriteLine();
  }
 }
}