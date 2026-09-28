// Write a program in C to find the sum of all elements of the array.

#include <stdio.h>
#include <stdlib.h>

int main(void)
{
 int n, elementSum = 0;

 // 打印题目
 printf("Find sum of all elements of array:\n");
 printf("--------------------------------------\n");

 // 提示输入数组长度
 printf("Input the number of elements to store in the array :");
 scanf("%d", &n);

 int *arr = (int *)malloc(n * sizeof(int)); // 动态分配内存
 if (arr == NULL)
 { // 如果内存分配失败
  printf("Memory allocation failed!\n");
  return 1;
 }

 // 提示在数组中输入 n 个元素
 printf("Input %d number of elements in the array : \n", n);
 for (int i = 0; i < n; i++)
 {
  printf("element - %d : ", i);
  scanf("%d", &arr[i]);
 }

 // 循环便利数组并使用数组下标计算数组中元素的和
 for (int i = 0; i < n; i++)
 {
  elementSum += arr[i];
 }

 printf("Sum of all elements stored in the array is : %d\n", elementSum);

 free(arr); // 释放手动分配的内存
 arr = NULL;

 return 0;
}