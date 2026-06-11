#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int n1, n2, i, gcd, lcm;

 printf("输入两个正整数: ");
 scanf("%d %d", &n1, &n2);

 for (i = 1; i <= n1 && i <= n2; ++i)
 {
  // 判断最大公约数
  if (n1 % i == 0 && n2 % i == 0)
   gcd = i;
 }

 lcm = (n1 * n2) / gcd;
 printf("%d 和 %d 的最小公倍数为 %d", n1, n2, lcm);

 return 0;
}