// 输入两个整数，然后计算并显示这两个整数的最大公约数（GCD）
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int m, n, r = 0;

 printf("Enter two integers: ");
 scanf("%d %d", &m, &n);

 while (n != 0)
 {
  r = m % n;
  m = n;
  n = r;
 }
 printf("Greatest common divisor: %d\n", m);

 return 0;
}