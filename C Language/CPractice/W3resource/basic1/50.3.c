// Write a C program to identify and print the indices and values of even numbers in an array.

#include <stdio.h>

#define SIZE 5 // 数组长度

int main(void)
{
 int arr[SIZE];

 printf("Input %d numbers of the array: \n", SIZE);
 for (int i = 0; i < SIZE; i++)
 {
  scanf("%d", &arr[i]);
 }

 // Print the indices and values of even numbers
 for (int i = 0; i < SIZE; i++)
 {
  if ((arr[i] % 2) == 0)
   printf("A[%d] = %d\n", i, arr[i]);
 }

 return 0;
}