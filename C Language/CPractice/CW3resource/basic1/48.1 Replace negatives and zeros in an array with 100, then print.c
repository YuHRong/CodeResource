// Write a C program that reads and prints the elements of an array of length 7. Before printing, replace every negative number, zero, with 100.
#include <stdio.h>

#define SIZE 7

int main(void)
{
 int numArr[SIZE], n;
 // int arr[SIZE];

 printf("Input the %d members of the array:\n", SIZE);
 for (int i = 0; i < SIZE; i++)
 {
  scanf("%d", &numArr[i]);
  // arr[i] = numArr[i];
 }

 printf("Array values are:\n");
 for (int i = 0; i < SIZE; i++)
 {
  if (numArr[i] <= 0)
  {
   numArr[i] = 100;
  }
  printf("n[%d] = %d\n", i, numArr[i]);
 }

 return 0;
}