#include<stdio.h>

int main(void)
{
 float inches;
 float cm;

 printf("请输入身高， 以英寸为单位:");
 scanf_s("%f", &inches);
 cm = inches * 2.54;
 printf("你的身高是 %.2f cm\n", cm);

 return 0;
}