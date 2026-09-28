// Write a C program that reads two integers and checks whether they are multiplied or not.

#include <stdio.h>

int main()
{
 int x, y; // 申明两个变量存储值
 int temp; // 申明中间变量存储最小值

 printf("Input first number: ");
 scanf("%d", &x);
 printf("Input second number: ");
 scanf("%d", &y);

 if (x > y)
 {
  temp = x;
  x = y;
  y = temp;
 }

 // 检查 x 是否为 y 的因子
 if ((y % x) == 0)
 {
  // 如果“x”是“y”的因子，则打印消息
  printf("\nMultiplied!\n");
 }
 else
 {
  printf("\nNot Multiplied!\n");
 }

 return 0;
}