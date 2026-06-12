#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int n, i;
 unsigned long long factorial = 1;

 printf("输入一个整数： ");
 scanf("%d", &n);

 // 如果输入是负数，显示错误
 if (n < 0)
  printf("Error! 负数没有阶乘jiechen");
 else
 {
  for (i = 1; i < n; ++i)
  {
   factorial *= i;              // factorial = factorial * i;
  }
  printf("%d! = %llu", n, factorial);
 }

 return 0;
}