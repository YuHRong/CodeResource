#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int n;

 printf("输入一个整数： ");
 scanf("%d", &n);

 printf("%d 的因数有: ", n);

 for (int i = 1; i <= n; i++)
 {
  if (n % i == 0)
  {
   printf("\n%d ", i);
  }
 }
 printf("\n");

return 0;
}