#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 double num1, num2, product;

 printf("请输入两个浮点数： ");
 scanf("%lf %lf", &num1, &num2);

 product = num1 * num2;

 // 以两位小数点打印乘机
 printf("%.2lf × %.2lf = %.2lf\n", num1, num2, product);

 return 0;
}