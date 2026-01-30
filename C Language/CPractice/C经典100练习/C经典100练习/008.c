//题目：  输出9*9 口诀
#include<stdio.h>

int main(void)
{
 int i, j, k;
 
 for (i = 1; i <= 9; i++)
 {
  for (j = 1; j <= i; j++)
  {
   printf("%d * %d = %-5d", i, j, i * j);
  }
  printf("\n");
 }
 return 0;
}