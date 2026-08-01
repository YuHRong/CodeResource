// Write a C program to read an array of length 5 and print the position and value of the array elements of value less than 5.

#include <stdio.h>

#define SIZE 5

int main(void)
{
 float arr[SIZE];

 printf("Input the %d members of the array:\n", SIZE);
 for (int i = 0; i < SIZE; i++)
  scanf("%f", &arr[i]);

 for (int i = 0; i < SIZE; i++)
 {
  if (arr[i] < 5)
   printf("A[%d] = %.1f\n", i, arr[i]);
 }

 return 0;
}