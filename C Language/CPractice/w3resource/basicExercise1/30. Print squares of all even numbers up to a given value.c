// Write a C program to find and print the square of all the even values from 1 to a specified value.

#include <stdio.h>

int main()
{
 int n;

 printf("Input the integer: ");
 scanf("%d", &n);

 printf("List of square of each one of the even values from 1 to a %d :\n", n);

 for (int i = 1; i <= n; i++)
 {
  if ((i % 2) == 0)
   printf("%d^2 = %d\n", i, i * i);
 }

 return 0;
}