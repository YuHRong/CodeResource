#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int n, i, sum = 0;

 printf("请输入一个正整数： ");
 scanf("%d", &n);

 i = 1;
 while (i <= n)
 {
  sum += i;
  ++i;
 }
 printf(" Sum = %d\n", sum);

 return 0;
}