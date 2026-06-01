#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int n, h, t, u;

 printf("Enter a two-digit number: ");
 scanf("%d", &n);

 h = n / 100;
 t = (n % 100) / 10;
 u = n % 10;
 printf("The reversal is: %d\n", u * 100 + t * 10 + h);

 return 0;
}