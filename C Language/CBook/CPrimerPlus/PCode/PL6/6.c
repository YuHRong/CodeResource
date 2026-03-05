#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int lower, upper, index;
 int  square, cube;

 // 输入下线
 printf("请输入起始整数: ");
 scanf("%d", &lower);

 // 输入上限
 printf("输入结束整数: ");
 scanf("%d", &upper);

 printf("%5s %10s %15s\n", "num", "square", "cube");

 // 使用循环打印该数的平方和立方
 for (index = lower; index <= upper; index++)
 {
  // 计算平方
  square = index * index;

  // 计算立方
  cube = index * square;

  printf("%5d %10d %15d\n", index, square, cube);
 }

 return 0;
}