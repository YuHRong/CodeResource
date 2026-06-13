#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<math.h>

int main(void)
{
 double base, exponent, result;

 printf("基数： ");
 scanf("%lf", &base);
 printf("指数： ");
 scanf("%lf", &exponent);

 result = pow(base, exponent);
 printf("%.1lf^%.1lf = %.2lf", base, exponent, result);

 return 0;
}