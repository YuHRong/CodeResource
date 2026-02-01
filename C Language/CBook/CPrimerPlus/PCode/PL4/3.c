#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 float num;

 printf("请输入一个浮点数:\n");
 scanf("%f", &num);
 printf("a.The input is%.1lf or %.1e.\n", num, num);
 printf("b.The input is %.3lf or %.3E.\n", num, num);

 return 0;
}