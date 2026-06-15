#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int n, originalNumber, remaimder, result = 0;

 printf("请输入一个三位数的整数： ");
 scanf("%d", &n);

 originalNumber = n;

 while (originalNumber != 0)
 {
  remaimder = originalNumber % 10;
  result += remaimder * remaimder * remaimder;
  originalNumber /= 10;
 }

 if (result == n)
  printf("%d 是 Armstrong 数\n", n);
 else
  printf("%d 不是 Armstrong 数", n);

 return 0;
}