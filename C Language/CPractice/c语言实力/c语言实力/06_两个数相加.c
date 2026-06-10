#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int num1, num2, sum;

 printf("请输入两个数，以空格分割: ");
 scanf("%d %d", &num1, &num2);

 sum = num1 + num2;

 printf("%d + %d = %d\n", num1, num2, sum);

 return 0;
}