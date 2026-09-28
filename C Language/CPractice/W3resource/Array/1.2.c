//
// Write a C program to input elements into an array dynamically using malloc() and print the array without using indexing.
//

#include <stdio.h>
#include <stdlib.h>

int main()
{
 int n;

 printf("Input the size of the array: ");
 scanf("%d", &n);

 // 使用 malloc 动态分配内存
 int *arr = (int *)malloc(n * sizeof(int));
 if (arr == NULL)
 { // 如果内存分配失败
  printf("Memory allocation failed!\n");
  return 1;
 }

 int *p = arr; // 指针指向动态分配的内存

 printf("Input %d elements (integer type) in the array: ", n);
 for (int i = 0; i < n; i++)
 {
  printf("element %d - ", i);
  scanf("%d", p + i);
 }

 printf("Elements in array are: ");
 for (int i = 0; i < n; i++)
  printf("%d ", *(p + i));
 printf("\n");

 free(arr); // 释放内存
 arr = NULL;

 return 0;
}