// 有一分数序列：2/1，3/2，5/3，8/5，13/8，21/13...求出这个数列的前20项之和。
// 分子和分母都是斐波那契数列，前两个数之和等于第三个数的值

#include <stdio.h>

int main()
{
 double f1 = 2, f2 = 1;
 double sum = 0.0;

 for (int i = 1; i <= 20; i++)
 {
  sum = sum + f1 / f2;
  int t = f1;
  f1 = f1 + f2;
  f2 = t;
 }

 printf("%f\n", sum);

 return 0;
}