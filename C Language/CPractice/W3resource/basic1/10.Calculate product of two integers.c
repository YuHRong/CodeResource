// Write a C program that accepts two integers from the user and calculates the product of the two integers.

#include <stdio.h>

int main(void)
{
 int n1, n2, product = 0;

 printf("Input the first integer: ");
 scanf("%d", &n1);
 printf("Input the second integer: ");
 scanf("%d", &n2);

 product = n1 * n2;

 printf("Productof the above two integers = %d\n", product);

 return 0;
}