// Write a C program to store elements in an array using pointer arithmetic and then print them in reverse order.

#include <stdio.h>

int main()
{
 int n;

 printf("Input the size of the array: ");
 scanf("%d", &n);

 // 申明一个大小为 n 的数组
 int arr[n];
 // 申明一个指向数组的指针
 int *p = arr;

 printf("Input %d elements (integer type) in the array: ", n);
 for (int i = 0; i < n; i++)
 {
  printf("element %d - ", i);
  scanf("%d", p + i);
 }

 printf("Array element of reverse  are : \n");
 for (int i = n - 1; i >= 0; i--)
 {
  printf("%d ", *(p + i));
 }
 printf("\n");

 return 0;
}