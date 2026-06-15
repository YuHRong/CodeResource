// 使用 * 打印三角形图案
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int rows;

 printf("输入行数： ");
 scanf("%d", &rows);

 for (int i = 1; i <= rows; i++) {
  for (int j = 1; j <= i; j++) {
   printf("* ");
  }
  printf("\n");
 }

 return 0;
}