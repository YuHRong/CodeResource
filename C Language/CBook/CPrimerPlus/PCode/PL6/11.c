#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

#define SIZE 8

int main(void)
{
 // 定义整数数组
 int input[SIZE];
 int i;

 // 提示用户输入 8 个整数
 printf("请输入 %d 个整数。\n", SIZE);
 for (i = 0; i < SIZE; i++)
 {
  scanf("%d", &input);
 }

 // 逆序打印8个整数
 printf("Here are the values in reverse order you entered:\n");
 for (i = SIZE - 1; i >= 0; i--)
 {
  printf("%d ", input[i]);
 }
 printf("\n");

 return 0;
}