// Write a C program to store numbers in an array and display them in reverse order using pointer decrement.

#include <stdio.h>
#include <stdlib.h>

int main(void)
{
 int n;

 printf("store numbers in an array and display in reverse order using pointer decrement.\n");
 printf("--------------------------------------------------------------------------------\n\n");
 printf("Input the number of elements to store in the array :");
 scanf("%d", &n);

 int *arr = (int *)malloc(n * sizeof(int)); // 动态分配内存
 if (arr == NULL)
 { // 如果内存分配失败
  printf("Memory allocation failed!\n");
  return 1;
 }

 int *ptr = arr + n - 1; // 申明一个指向分配内存的最后一个位置

 printf("Input %d number of elements in the array : \n", n);
 for (int i = 0; i < n; i++)
 {
  printf("element - %d : ", i);
  scanf("%d", &arr[i]);
 }

 printf("display array in reverse order using pointer decrement.\n");
 for (int i = 0; i < n; i++)
 {
  printf("%d ", *ptr);
  ptr--;
 }

 free(arr); // 释放手动分配的内存
 arr = NULL;

 return 0;
}