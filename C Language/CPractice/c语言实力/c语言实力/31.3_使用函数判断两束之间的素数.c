#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int checkPrimeNumber(int n);

int main(void)
{
 int n1, n2, i, flag;

 printf("输入两个正整数: ");
 scanf("%d %d", &n1, &n2);

 printf("%d 和 %d 间的素数为: ", n1, n2);

 for (i = n1 + 1; i < n2; ++i)
 {
  // 判断是否为素数
  flag = checkPrimeNumber(i);

  if (flag == 1)
   printf("%d ", i);
 }

 return 0;
}

int checkPrimeNumber(int n)
{
 int j, flag = 1;

 for (j = 2; j <= n / 2; ++j)
 {
  if (n % j == 0)
  {
   flag = 0;
   break;
  }
 }

 return flag;
}