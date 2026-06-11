#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int t1 = 0, t2 = 1, nt = 0, n;

 printf("输入一个正整数： ");
 scanf("%d", &n);

 // 显示前两项
 printf("斐波那契数列： %d, %d, ", t1, t2);

 nt = t1 + t2;

 while (nt <= n)
 {
  printf("%d, ", nt);
  t1 = t2;
  t2 = nt;
  nt = t1 + t2;
 }

 return 0;
}