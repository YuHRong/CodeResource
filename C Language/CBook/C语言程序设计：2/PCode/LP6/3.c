// 输入一个分数，然后将其约分为最简分式
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int n1, n2, m1, m2, temp;

 printf("Enter a fraction: ");
 scanf("%d/%d", &n1, &n2);

 // 使用中间变量存储分子和分母
 m1 = n1;
 m2 = n2;

 // 求最大公约数
 while (m2 != 0)
 {
  temp = m1 % m2;
  m1 = m2;
  m2 = temp;
 }

 // 分子和分母互相除以最大公约数
 n1 /= m1;
 n2 /= m1;

 printf("In lowest terms: %d/%d\n", n1, n2);

 return 0;
}