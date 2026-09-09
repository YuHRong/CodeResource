// Write a C program that reads 5 numbers and sums all odd values between them.

#include <stdio.h>

int main(void)
{
 int n1, n2, n3, n4, n5;
 int sum = 0;

 printf("Sum all odd numbers among five inputs\n");

 printf("Input the first number: ");
 scanf("%d", &n1);
 printf("Input the second number: ");
 scanf("%d", &n2);
 printf("Input the third number: ");
 scanf("%d", &n3);
 printf("Input the four number: ");
 scanf("%d", &n4);
 printf("Input the fifth number: ");
 scanf("%d", &n5);

 if ((n1 % 2) != 0)
  sum += n1;

 if ((n2 % 2) != 0)
  sum += n2;

 if ((n3 % 2) != 0)
  sum += n3;

 if ((n4 % 2) != 0)
  sum += n4;

 if ((n5 % 2) != 0)
  sum += n5;

 printf("Sum of all odd values: %d\n", sum);

 return 0;
}