// Write a C program to populate an array where each element is the square of the previous element, starting from an initial value.

#include <stdio.h>
#define MAX_SIZE 5
int main(void)
{
 long long arr[MAX_SIZE];
 int size;

 printf("Input first number of the array:");
 scanf("%lld", &arr[0]);
 printf("Input the size of the array (max %d):", MAX_SIZE);
 scanf("%d", &size);

 if (size > MAX_SIZE || size < 1)
 {
  printf("Error: Size must be between 1 and %d\n", MAX_SIZE);
  return 1;
 }

 for (int i = 1; i < size; i++)
  arr[i] = arr[i - 1] * arr[i - 1];

 for (int i = 0; i < size; i++)
  printf("%lld\n", arr[i]);

 return 0;
}