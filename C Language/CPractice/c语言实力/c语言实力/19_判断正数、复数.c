#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main()
{
 double num;

 printf("输入一个数字： ");
 scanf("%lf", &num);

 if (num <= 0)
 {
  if (num == 0)
   printf("你输入的是 0\n");
  else
   printf("%.2lf 是复数\n", num);
 }
 else
  printf("%.2lf 是正数\n", num);

 return 0;
}