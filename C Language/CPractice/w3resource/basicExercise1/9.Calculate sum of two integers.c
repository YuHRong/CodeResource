// Write a C program that accepts two integers from the user and calculates the sum of the two integers.

#include <stdio.h>

int main (void)
{
 int n1, n2, sum = 0;

 printf("Input the first integer: ");
 scanf("%d", &n1);
 printf("Input the second integer: ");
 scanf("%d", &n2);

 sum = n1 + n2;
 printf("Sum of the above two integers = %d\n", sum);

 return 0;
}