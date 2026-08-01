// Write a C program to populate an array where each element is the sum of the two preceding elements.

#include <stdio.h>

#define MAX_SIZE 100

int main(void)
{
 int arr[MAX_SIZE];
 int size;

 printf("Input first number of the array: ");
 scanf("%d", &arr[0]);

 printf("Input second number of the array: ");
 scanf("%d", &arr[1]);

 printf("Input the MAX_SIZE of the array: ");
 scanf("%d", &size);

 if (size < 2 || size > MAX_SIZE)
 {
  printf("Error: Size must be between 2 and %d\n", MAX_SIZE);
  return 1;
 }

 for (int i = 2; i < size; i++)
  arr[i] = arr[i - 1] + arr[i - 2];

 printf("Array values are:\n");
 for (int i = 0; i < size; i++)
  printf("%d\n", arr[i]);

 return 0;
}