// 使用 for 循环打印乘法口诀表
#include<stdio.h>

int main(void)
{
 // 外层循环控制行
 for (int i = 1; i <= 9; i++)
 {
  // 内存循环控制列
  for (int j = 1; j <= i; j++)
  {
   printf("%d * %d = %d\t", i, j, i * j);
  }
  printf("\n");
 }

 return 0;
}