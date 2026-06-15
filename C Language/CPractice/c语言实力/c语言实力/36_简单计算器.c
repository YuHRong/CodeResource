#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 char op;
 double n1, n2;

 printf("请输入运算符（加（+）、减（-）、乘（*）、除（/）： ");
 scanf("%c", &op);

 printf("输入两个数，以空格分割： ");
 scanf("%lf %lf", &n1, &n2);

 switch (op)
 {
 case '+': printf("%.2lf + %.2lf = %.2lf\n", n1, n2, n1 + n2); break;
 case '-': printf("%.2lf - %.2lf = %.2lf\n", n1, n2, n1 - n2); break;
 case '*': printf("%.2lf * %.2lf = %.2lf\n", n1, n2, n1 * n2); break;
 case '/': printf("%.2lf / %.2lf = %.2lf\n", n1, n2, n1 / n2); break;
 default: printf("请输入正确的运算符\n"); break;    // 如果运算符不匹配
 }

 return 0;
}