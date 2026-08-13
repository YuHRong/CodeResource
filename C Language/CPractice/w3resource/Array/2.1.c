// Write a C program to read n elements into an array and print them in alternating order from both ends.

#include <stdio.h>
#include <stdlib.h>

int main()
{
 int n;

 printf("Input the number of elements to store in the array :");
 scanf("%d", &n);

 // 动态分配内存
 int *arr = (int *)malloc(n * sizeof(int));
 if (arr == NULL)
 { // 如果内存分配失败
  printf("Memory allocation failed!\n");
  return 1;
 }

 int *left_ptr = arr;          // 申明一个指针指向 动态分配的内存起始位置
 int *right_ptr = arr + n - 1; // 申明一个指针指向动态分配内存的最后一个位置

 printf("Input %d number of elements in the array :", n);
 for (int i = 0; i < n; i++)
 {
  printf("element - %d", i);
  scanf("%d", (left_ptr + i));
 }

 while (left_ptr < right_ptr)
 {
  printf("%d ", *left_ptr);
  left_ptr++;

  printf("%d ", *right_ptr);
  right_ptr--;
 }

 if (left_ptr == right_ptr)
  printf("%d", *left_ptr);
 printf("\n");

 free(arr);
 arr = NULL;

 return 0;
}