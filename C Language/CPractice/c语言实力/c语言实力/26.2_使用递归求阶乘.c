#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

long int multiplyNumbers(int n);

int main(void)
{
 int n;

 printf("输入一个整数: ");
 scanf("%d", &n);
 printf("%d! = %ld", n, multiplyNumbers(n));

 return 0;
}

long int multiplyNumbers(int n)
{
 if (n > 1)
  return n * multiplyNumbers(n - 1);

 else
  return 1;
}