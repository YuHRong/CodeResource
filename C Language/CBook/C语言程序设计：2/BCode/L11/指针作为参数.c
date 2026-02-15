#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int i, * p;
 p = &i;
 printf("请输入: ");
 scanf("%d", p);    // 正确写法
 printf("请输入: ");
 scanf("%d", &p);    // 错误写法。
 printf("%d\n", i);
 printf("%d\n", p);

 return 0;
}