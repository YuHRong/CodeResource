#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

#define SIZE 8

int main(void)
{
 double ar1[SIZE], ar2[SIZE];
 int i;

 // 提示用户输入8个double类型的数，并赋值给第一个数组
 printf("Enter %d numbers to the FIRST array:\n", SIZE);
 for (i = 0; i < SIZE; i++)
 {
  scanf("%lf", &ar1[i]);
 }

 // 使用一个循环
 ar2[0] = ar1[0];
 for (i = 1; i < SIZE; i++)
 {
  ar2[i] = ar2[i - 1] + ar1[i];
 }

 // 打印两个数组
 printf("All the data of  two array:\n");
 printf("First  Array: ");
 for (int i = 0; i < 8; i++)
 {
  printf("%10lf. ", ar1[i]);
 }
 printf("\nSecond Array: ");
 for (int i = 0; i < 8; i++)
 {
  printf("%10lf. ", ar2[i]);
 }

 return 0;
}