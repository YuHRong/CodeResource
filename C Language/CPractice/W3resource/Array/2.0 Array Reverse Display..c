// Write a program in C to read n number of values in an array and display them in reverse order.

#include <stdio.h>
#include <stdlib.h>

int main(void)
{
 int n;

 printf("Input the number of elements to store in the array :");
 scanf("%d", &n);
 // int arr[n];

 // 使用 malloc 动态分配内存
 int *arr = (int *)malloc(n * sizeof(int));
 // arr = NULL;
 if (arr == NULL)
 { // 如果内存分配失败
  printf("Memory allocation failed!\n");
  return 1;
 }

 int *ptr = arr; // 申明一个指针指向 动态分配的内存起始位置

 printf("Input %d number of elements in the array :", n);
 for (int i = 0; i < n; i++)
 {
  printf("element - %d", i);
  scanf("%d", (ptr + i));
 }

 printf("The values store into the array are :\n");
 for (int i = 0; i < n; i++)
  printf("%d ", *(ptr + i));
 printf("\n");

 printf("The values store into the array in reverse are :\n");
 for (int i = n - 1; i >= 0; i--)
  printf("%d ", *(ptr + i));
 printf("\n");

 free(arr); // 释放动态分配的内存
 arr = NULL;

 return 0;
}