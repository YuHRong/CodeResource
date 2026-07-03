#include <stdio.h>

double power(double n, int p); // ANSI函数原型

int main(void)
{
 double x, xpow;
 int exp;

 printf("Enter a number and the positive integer power");
 printf(" to which\nthe number will be raised. Enter q");
 printf(" to quit.\n");

 while (scanf("%lf%d", &x, &exp) == 2)
 {
  xpow = power(x, exp); // 函数调用
  printf("%.3g to the power %d is %.5g\n", x, exp, xpow);
  printf("Enter next pair of numbers or q to quit.\n");
 }
 printf("Hope you enjoyed this power trip -- bye!\n");

 return 0;
}

double power(double n, int p) // 函数定义
{
 // 0未定义
 // 任何数的0次幂都是1
 if (n == 0 && p == 0)
 {
  printf("0 to the 0 undefined; using 1 as the value\n");
  return 1;
 }

 // 0 的任何次幂都是 0
 if (n == 0)
 {
  return 0.0;
 }

 // 任何飞0数的0次幂都是1
 if (p == 0)
 {
  return 1;
 }

 // 计算正整数幂

 // 使用递归
 // 计算复整数幂
 if (p < 0)
 {
  return 1.0 / power(n, -p);
 }

 // 处理证幂
 // n^p = n * n^(p-1)
 return n * power(n, p - 1);
}