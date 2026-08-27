// Write a program in C to count the total number of duplicate elements in an array.

#include <stdio.h>
#include <stdlib.h>

int main(void)
{
 int n, count = 0;

 printf("Input the number of elements to be stored in the array : ");
 scanf("%d", &n);

 int *arr = (int *)malloc(n * sizeof(int));
 if (arr == NULL)
 {                                       // 如果内存分配失败
  printf("Memory allocation failed!\n"); // 修正拼写错误
  return 1;
 }

 // 申明指向数组开头的指针
 int *pArr = arr;

 printf("Input %d element in the array :\n", n);
 // 循环写入数组元素
 for (int i = 0; i < n; i++)
 {
  printf("element - %d : ", i);
  scanf("%d", pArr);
  pArr++;
 }

 pArr = arr;
 for (int i = 0; i < n; i++)
 {
  if (arr[i] == arr[i + 1])
  {
   count++;
  }
 }

 printf("Total number of duplicate elements found in the array is : %d\n", count);

 free(arr);

 return 0;
}