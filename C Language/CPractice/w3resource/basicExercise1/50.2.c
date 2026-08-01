// Write a C program to print the positions and values of array elements that are greater than 10.
#include <stdio.h>

#define SIZE 5 // 申明数组长度
#define MAX 10 // 申明需要比较的值

int main()
{
 float arr[SIZE];

 printf("Input the %d members of the array:\n", SIZE);
 for (int i = 0; i < SIZE; i++)
 {
  scanf("%f", &arr[i]);
 }

 for (int i = 0; i < SIZE; i++)
 {
  if (arr[i] > MAX)
   printf("A[%d] = %.1f\n", i, arr[i]);
 }

 return 0;
}