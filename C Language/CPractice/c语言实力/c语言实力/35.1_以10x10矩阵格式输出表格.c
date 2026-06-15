// 将 1-100 的数据以 10x10 矩阵格式输出。
#include<stdio.h>

int main(void)
{
 for (int i = 1; i <= 10; i++)
 {
  for (int j = i; j <= 100; j += 10)
  {
   printf("%3d", j);
  }
 printf("\n");
 }
 return 0;
}