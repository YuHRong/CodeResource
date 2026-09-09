// Write a C program to calculate the sum of even-indexed elements in an array.

#include <stdio.h>
#include <stdlib.h>

int main(void)
{
 int n, sum = 0;

 printf("\ncalculate the sum of even-indexed elements in an array.\n");
 printf("-----------------------------------------------------------\n\n");

 // 提示输入数组长度
 printf("Input the number of elements to store in the array :");
 scanf("%d", &n);

 int *arr = (int *)malloc(n * sizeof(int)); // 动态分配内存
 if (arr == NULL)
 { // 如果内存分配失败
  printf("Memory allocation failed!\n");
  return 1;
 }

 printf("Input %d number of elements in the array : \n", n);
 for (int i = 0; i < n; i++)
 {
  printf("element - %d :", i + 1);
  scanf("%d", &arr[i]);
 }

 // 循环便利数组，找出偶数下标的元素并计算
 for (int i = 0; i < n; i += 2)
 {
  sum += arr[i];
 }

 printf("sum of even-indexed elements in an array is %d\n", sum);

 free(arr); // 释放动态分配的内存
 arr = NULL;

 return 0;
}