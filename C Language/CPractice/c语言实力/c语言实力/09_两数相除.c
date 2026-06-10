// 两束相除，有余数打印余数
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int dividend, divisor, quotient, remainder;

 printf("输入被除数： ");
 scanf("%d", &dividend);

 printf("输入除数： ");
 scanf("%d", &divisor);

 quotient = dividend / divisor;
 remainder = dividend % divisor;

 printf("%d ÷ %d 的商 = %d\n", dividend, divisor, quotient);
 printf("\t余数 = %d\n", remainder);

 return 0;
}