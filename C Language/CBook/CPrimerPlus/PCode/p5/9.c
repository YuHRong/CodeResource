#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

void temperatures(double number);
int main(void)
{
 double fahrenheit;

 printf("请输入华氏度:\n");
 while(scanf("%lf", &fahrenheit) == 1)
 {
  temperatures(fahrenheit);
  printf("请输入华氏度(键入q退出):\n");
 }
 printf("bye.\n");
 return 0;
}

void temperatures(double number)
{
 double celsius, openTemperature;
 const double num1 = 5.0, num2 = 9.0, num3 = 32.0, num4 = 273.16;
 celsius = num1 / num2 * (number - num3);
 openTemperature = celsius + num4;
 printf("\t%.2f 华氏度是 \n\t%.2f 摄氏度 \n\t%.2f 开式度\n", number, celsius, openTemperature);
}