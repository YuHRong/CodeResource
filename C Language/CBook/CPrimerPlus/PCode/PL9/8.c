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
 double pow = 1;
 int i;
 int abs_p; // 用于存储 p 的绝对值

 // 0未定义
 // 任何数的0次幂都是1
 if (n == 0 || p == 0)
 {
  printf("0 to the 0 undefined; using 1 as the value\n");
  return 1;
 }

 // 0 的任何次幂都是 0
 if (n == 0)
 {
  return 0.0;
 }

 // 先获取指数的绝对值
 abs_p = (p < 0) ? -p : p;

 // 计算正整数幂
 for (i = 1; i <= abs_p; i++)
 {
  pow *= n;
 }

 // 计算复整数幂
 if (p < 0)
 {
  pow = 1.0 / pow;
 }

 return pow;
}