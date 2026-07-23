// Write a C program to print 3 numbers on a line, starting with 1 and printing n lines. Accept the number of lines (n, integer) from the user.
/*
申明一个打印数字的计数变量
 获取一个正整数控制列，
 在循环内部，
 外层循环控制行，
 内部循环打印行中的数字，
 每一行三个数字。
*/

#include <stdio.h>

int main()
{
 int n, count = 1;

 printf("Input number of lines: ");
 scanf("%d", &n);

 for (int i = 0; i < n; i++)
 {
  for (int j = 0; j < 3; j++)
  {
   printf("%d ", count++);
  }
  printf("\n");
 }

 return 0;
}