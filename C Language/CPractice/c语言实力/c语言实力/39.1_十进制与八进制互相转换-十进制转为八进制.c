#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<math.h>

int convertDecimalToOctal(int n);

int main(void)
{
 int decimalNumber;

 printf("输入一个十进制数: ");
 scanf("%d", &decimalNumber);

 printf("十进制数 %d 转换为八进制为 %d", decimalNumber, convertDecimalToOctal(decimalNumber));

 return 0;
}

int convertDecimalToOctal(int n)
{
 int octalNumber = 0, i = 1;

 while (n != 0)
 {
  octalNumber += (n % 8) * i;
  n/= 8;
  i *= 10;
 }

 return octalNumber;
}