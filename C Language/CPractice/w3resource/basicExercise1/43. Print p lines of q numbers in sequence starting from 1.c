// Write a C program that reads two integers p and q, prints p number of lines in a sequence of 1 to b in a line.
/*
获取两个整数，
第一个整数控制行，是外层循环条件，
第二个整数控制列，是内部循环条件。
申明一个打印数字的变量，初始化为 1
*/

#include <stdio.h>

int main()
{
 int p, q, count = 1;

 printf("Input number of lines: ");
 scanf("%d", &p);
 printf("Number of characters in a line: ");
 scanf("%d", &q);

 for (int i = 1; i <= p; i++)
 {
  for (int j = 0; j < q; j++)
  {
   printf("%d ", count++);
  }
  printf("\n");
 }

 return 0;
}