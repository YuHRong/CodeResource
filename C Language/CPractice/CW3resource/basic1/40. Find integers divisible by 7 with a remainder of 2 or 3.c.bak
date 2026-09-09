// Write a C program that finds all integer numbers that divide by 7 and have a remainder of 2 or 3 between two given integers.
/*
获取两个整数，
保持第一个值是最小，
使用获取到的两个整数作为循环条件，
找出能被 7 整除且除以 7 的余数等于 2 或余数等于 3 的整数 ，
在循环内部打印
 */

#include <stdio.h>

int main()
{
 int n1, n2;

 printf("Input first integer: ");
 scanf("%d", &n1);
 printf("Input second integer: ");
 scanf("%d", &n2);

 if (n1 > n2)
 {
  int temp = n1;
  n1 = n2;
  n2 = temp;
 }

 for (int i = n1; i < n2; i++)
 {
  if ((i % 7) == 2 || (i % 7) == 3)
  {
   printf("%d\n", i);
  }
 }

 return 0;
}