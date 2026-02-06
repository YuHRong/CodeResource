#include<stdio.h>
#include<float.h>

int main(void)
{
 double a = 1.0 / 3.0;
 float b = 1.0 / 3.0;

 printf("%.6f %20.6f\n", a, b);
 printf("%.12f %20.12f\n", a, b);
 printf("%.16f %20.16f\n", a, b);
 printf("%d %20d\n", FLT_DIG,DBL_DIG);

 return 0;
}