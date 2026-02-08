#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

void result(double number);
void main()
{
 double num;

 printf("请输入一个小数点数字:\n");
 scanf("%lf", &num);
 result(num);
 return 0;
}

void result(double number)
{
 double   sum = number * number * number;

 printf("%.4f\n", sum);
}