// Write a C program to identify duplicate elements in an array and replace them with a sentinel value, such as -1.

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
  if (numArr[i] == -1)
   continue;

  for (int j = 0; j < i; j++)
  {
   if (numArr[j] == -1)
    continue;

   if (numArr[i] == numArr[j])
   {
    numArr[i] = -1;
    break;
   }
  }

  printf("n[%d] = %d\n", i, numArr[i]);
 }

 return 0;
}