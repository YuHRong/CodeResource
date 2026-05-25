#include<stdio.h>

#define SIZE 8

int main(void)
{
 // 定义一个包含8个元素的数组
 int ar[SIZE];
 int i;
 int value = 1;

 // 设置数组元素的值
 for (i = 0; i < SIZE; i++)
 {
  // 根据 i 设置为 2 的 i 次密
  ar[i] = value;
  value *= 2;
 }

 i = 0;
 // 使用do while循环显示数组元素的值
 printf("Here are the list values:\n");
 do
 {
  printf("%d ", ar[i++]);
 } while (i < SIZE);
 printf("\n");

 return 0;
}