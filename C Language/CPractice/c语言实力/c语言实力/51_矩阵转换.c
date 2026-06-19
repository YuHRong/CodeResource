#include <stdio.h>

int main(void)
{
 int r, c, a[10][10], transpose[10][10];

 printf("输入矩阵的行列： ");
 scanf("%d %d", &r, &c);

 // 存储矩阵的元素
 printf("\n\n");
 for (int i = 0; i < r; ++i)
 {
  for (int j = 0; j < c; ++j)
  {
   printf("输入元素 a%d%d： ", i + 1, j + 1);
   scanf("%d", &a[i][j]);
  }
 }

 // 显示矩阵 a[][]
 printf("\n\n");
 for (int i = 0; i < r; ++i)
 {
  for (int j = 0; j < c; ++j)
  {
   printf("%d  ", a[i][j]);
   if (j == c - 1)
    printf("\n\n");
  }
 }

 // 转换
 for (int i = 0; i < r; ++i)
 {
  for (int j = 0; j < c; ++j)
  {
   transpose[j][i] = a[i][j];
  }
 }

 // 显示转换后的矩阵
 printf("\n\n转换后矩阵\n\n");
 for (int i = 0; i < c; ++i)
 {
  for (int j = 0; j < r; ++j)
  {
   printf("%d  ", transpose[i][j]);

   if (j == r - 1)
    printf("\n");
  }
 }

 return 0;
}