// Write a program in C to store elements in an array and print them.
#include <stdio.h>

#define S 10
int main()
{
 int arr[S];

 printf("Input %d elements in the array : \n", S);
 for (int i = 0; i < S; i++)
 { // 循环写入数组元素
  printf("element: %d", i);
  scanf("%d", &arr[i]);
 }

 printf("Elements in array are: ");
 for (int i = 0; i < S; i++)
 { // 循环打印数组元素
  printf("%d ", arr[i]);
 }

 return 0;
}