// 获取输入付款金额，计算怎样使用最少的20美元、10美元、5美元、1美元进行付款
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int amount, twenty, ten, five, one;

 printf("Enter a dollar amount: ");
 scanf("%d", &amount);

 twenty = amount / 20;
 amount = amount - twenty * 20;

 ten = amount / 10;
 amount = amount - ten * 10;

 five = amount / 5;
 amount = amount - five * 5;

 one = amount / 1;

 printf("$20 bills: %d\n", twenty);
 printf("$10 bills: %d\n", ten);
 printf("$5 bills: %d\n", five);
 printf("$1 bills: %d\n", one);

 return 0;
}