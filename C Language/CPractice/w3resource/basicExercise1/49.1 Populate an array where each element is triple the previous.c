// Write a C program to read and print the elements of an array with length 7. Before printing, insert the triple of the previous position, starting from the second position.

#include <stdio.h>

#define SIZE 7

int main(void)
{
 int arr[SIZE];

 printf("Input the first number of the array: ");
 scanf("%d", &arr[0]);

 for (int i = 1; i < SIZE; i++)
 {
  arr[i] = arr[i - 1] * 3;
 }

 for (int i = 0; i < SIZE; i++)
  printf("n[%d] = %d\n", i, arr[i]);

 return 0;
}