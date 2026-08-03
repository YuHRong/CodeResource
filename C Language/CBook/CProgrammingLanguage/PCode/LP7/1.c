/* Prints a table of squares using a for statement */
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 long long i, n;

 printf("This program prints a table of squares.\n");
 printf("Enter number of entries in table: ");
 scanf("%lld", &n);

 for (i = 10000; i <= n; i++)
  printf("%20lld%20lld\n", i, i * i);

 return 0;
}