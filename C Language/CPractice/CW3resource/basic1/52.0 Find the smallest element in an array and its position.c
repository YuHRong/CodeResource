// Write a C program to read an array of length 6 and find the smallest element and its position.

#include <stdio.h>
#include <stdlib.h>

int main(void)
{
 int n;

 printf("Input the length of the array: ");
 scanf("%d", &n);

 int *arr = (int *)malloc(n * sizeof(int));
 if (arr == NULL)
 { // 如果内存分配失败
  printf("Memory alloction failed!\n");
  return 1;
 }

 printf("Input the array elements:");
 for (int i = 0; i < n; i++)
 {
  scanf("%d", &arr[i]);
 }

 int small, position;
 small = arr[0];
 position = 0;

 for (int i = 0; i < n; i++)
 {
  if (arr[i] < small)
  {
   small = arr[i];
   position = i;
  }
 }

 printf("Smallest Value: %d\n", small);
 printf("Position of the element: %d\n", position);

 free(arr); // 释放手动挡分配的内存
 arr = NULL;

 return 0;
}