// Write a C program to find the sum of array elements using pointer arithmetic without an index variable.

#include <stdio.h>
#include <stdlib.h>

int main(void)
{
 int n, sum = 0;

 printf("\nfind the sum of array elements using pointer arithmetic without an index variable.\n");
 printf("--------------------------------------------------\n\n");

 // 提示输入数组长度
 printf("Input the number of elements to store in the array :");
 scanf("%d", &n);

 int *arr = (int *)malloc(n * sizeof(int)); // 动态分配内存
 if (arr == NULL)
 { // 如果内存分配失败
  printf("Memory allocation failed!\n");
  return 1;
 }

 int *pCount = arr;     // 申明一个指向数组开头的指针
 int *pRight = arr + n; // 申明一个指向动态分配的内存最后的位置

 // 直接使用指针输入元素的值
 printf("Input %d number of elements in the array : \n", n);
 while (pCount < pRight)
 {
  printf("Element - %d : ", (int)(pCount - arr + 1)); // 使用指针减法计算当前是第几个元素
  scanf("%d", pCount);
  pCount++;
 }

 pCount = arr; // 重置 pCount 指向内存开始处

 while (pCount < pRight)
 {
  sum += *pCount;
  pCount++;
 }

 printf("the sum of array elements pointer is %d\n", sum);

 free(arr);  // 释放内存
 arr = NULL; // 将指针初始化为悬空状态

 return 0;
}