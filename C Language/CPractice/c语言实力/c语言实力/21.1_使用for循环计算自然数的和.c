#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int n, i, sum = 0;

 printf("请输入一个正整数： ");
 scanf("%d", &n);

 for (i = 1; i <= n; i++) 
 {
  sum += i;    // sum = sum + i;
 }
 printf("sum = %d\n", sum);

 return 0;
}