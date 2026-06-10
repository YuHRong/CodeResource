#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 char c;

 printf("请输入一个字符： ");
 scanf("%c", &c);

 printf("%c 的 ASCII码为 %d\n", c, c);

 return 0;
}