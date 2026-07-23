// Write a C program to calculate the sum of all numbers not divisible by 17 between two given integer numbers.
/*
读取两个整数，
使用读取的整数作为循环条件，
保持第一个输入的整数为最小值，
若是最大值，让他与第二个整数交换位置。
在循环内部，使用球磨运算符 求 17的余数，
若取 17 等于0则跳过。
*/

#include <stdio.h>

int main()
{
 int n1, n2;
 int sum = 0;

 printf("Input first integer: ");
 scanf("%d", &n1);
 printf("Input second integer: ");
 scanf("%d", &n2);

 if (n1 > n2)
 {
  n1 = n1 + n2;
  n2 = n1 - n2;
  n1 = n1 - n2;
 }

 for (int i = n1; i <= n2; i++)
 {
  if ((i % 17) != 0)
  {
   sum += i;
  }
 }
 printf("Sum: %d\n", sum);

 return 0;
}