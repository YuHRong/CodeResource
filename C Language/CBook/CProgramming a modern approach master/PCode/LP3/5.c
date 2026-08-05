#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16;

 printf("Enter the numbers from 1 to 16 in any order:");
 scanf("%d %d %d %d %d %d %d %d %d %d %d %d %d %d %d %d", &a1, &a2, &a3, &a4, &a5, &a6, &a7, &a8,
  &a9, &a10, &a11, &a12, &a13, &a14, &a15, &a16);

 // 打印每行四列，共四行。
 printf("%4d%4d%4d%4d\n", a1, a2, a3, a4);
 printf("%4d%4d%4d%4d\n", a5, a6, a7, a8);
 printf("%4d%4d%4d%4d\n", a9, a10, a11, a12);
 printf("%4d%4d%4d%4d\n", a13, a14, a15, a16);

 // 计算并输出每一行的和
 int row1 = a1 + a2 + a3 + a4;
 int row2 = a5 + a6 + a7 + a8;
 int row3 = a9 + a10 + a11 + a12;
 int row4 = a13 + a14 + a15 + a16;
 printf("Row sums: %d %d %d %d\n", row1, row2, row3, row4);

 // 计算并输出列合
 int col1 = a1 + a5 + a9 + a13;
 int col2 = a2 + a6 + a10 + a14;
 int col3 = a3 + a7 + a11 + a15;
 int col4 = a4 + a8 + a12 + a16;
 printf("Column sums: %d %d %d %d\n", col1, col2, col3, col4);

 // 计算并输出对角线
 int diagonal1 = a1 + a6 + a11 + a16;   // 主对角线
 int diagonal2 = a4 + a7 + a10 + a13;    // 副对角线
 printf("Diagonal sums: %d %d\n", diagonal1, diagonal2);

 return 0;
}