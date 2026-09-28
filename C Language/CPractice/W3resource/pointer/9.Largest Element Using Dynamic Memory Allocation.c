// Write a program in C to find the largest element using Dynamic Memory Allocation.

#include <stdio.h>
#include <stdlib.h>

int main(void)
{
 int n;
 float *element; // 指向存储元素的浮点类型的指针

 printf("\n\n Pointer : Find the largest element using Dynamic Memory Allocation :\n");
 printf("-------------------------------------------------------------------------\n");

 printf(" Input total number of elements (1 to 100): ");
 scanf("%d", &n);

 // 为“n”个元素分配内存
 element = (float *)calloc(n, sizeof(float));
 if (element == NULL)
 {
  // 如果内存分配失败
  printf(" No memory is allocated.");
  exit(0);
 }
 printf("\n");

 // 输入'n'个数字并将其动态存储在分配的内存中
 for (int i = 0; i < n; ++i)
 {
  printf("Number %d", i + 1);
  scanf("%f", element + i);
 }

 // 在“n”个元素中找到最大的元素
 for (int i = 1; i < n; ++i)
 {
  if (*element < *(element + i))
  {
   // 将最大的元素存储在第一个内存位置
   *element = *(element + i);
  }
 }
 printf(" The Largest element is :  %.2f \n\n", *element);

 return 0;
}