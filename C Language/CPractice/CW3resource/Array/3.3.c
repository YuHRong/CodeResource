// Write a C program to input an array and then compute both the sum and the product of its elements.

#include <stdio.h>
#include <stdlib.h>

int main(void)
{
 int n, sum = 0, product = 1;

 printf("\ninput an array and then compute both the sum and the product of its elements.\n");
 printf("-------------------------------------------------\n");

 printf("\nInput the number of elements to store in the array");
 scanf("%d", &n);

 int *arr = (int *)malloc(n * sizeof(int));
 if (arr == NULL)
 { // 如果内存分配失败
  printf("Memory alloction failed!\n");
  return 1;
 }

 int *pStart = arr;   // 申明一个指向分配的内存开始处的指针
 int *pEnd = arr + n; // 申明一个指向分配内存结束位置的指针

 //
 // 提示输入数组的元素
 //
 printf("Input %d number of elements in the array:\n", n);
 while (pStart < pEnd)
 {
  printf("element - %d : ", (int)(pStart - arr));
  scanf("%d", pStart);
  pStart++;
 }

 pStart = arr; // 重置 pStart 指向内存的开始处

 //
 // 循环计算数组的 sum 和 product
 //
 while (pStart < pEnd)
 {
  sum += *pStart;
  product *= *pStart;
  pStart++;
 }

 printf("Sum of the array is %d\n", sum);
 printf("Product of the array is %d\n", product);

 free(arr);  // 释放手动分配的内存
 arr = NULL; // 将 arr 指针初始化为空

 return 0;
}