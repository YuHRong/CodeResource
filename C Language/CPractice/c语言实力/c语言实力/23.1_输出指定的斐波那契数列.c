#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int i, n, t1 = 0, t2 = 1, nT;

 printf("输出几项： ");
 scanf("%d", &n);

 printf("斐波那契数列: ");

 for (i = 1; i < n; ++i)
 {
  printf("%d, ", t1);
  nT = t1 + t2;
  t1 = t2;
  t2 = nT;
 }

 return 0;
}