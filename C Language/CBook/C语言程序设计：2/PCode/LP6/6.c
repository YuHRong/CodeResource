// 输入一个数，然后显示出1～ 的所有偶数平方值。
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int n;

 printf("Enter a positive integer: ");
 scanf("%d", &n);

 for (int i = 2; i * i <= n; i += 2)
  printf("%d\n", i * i);

 return 0;
}