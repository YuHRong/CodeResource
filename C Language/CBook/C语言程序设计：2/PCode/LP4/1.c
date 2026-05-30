#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int n, t, u;

 printf("Enter a two-digit number: ");
 scanf("%d", &n);

 t = n / 10;
 u = n % 10;
 printf("The reversal is: %d\n", u * 10 + t);

 return 0;
}