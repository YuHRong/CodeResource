#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int i;
 float f;

 printf("请输入第一个数字： ");
 scanf("%d", &i);
 printf("输入第二个数字： ");
 scanf("%f", &f);
 int sum = i + f;
 printf("%d\n", sum);

 return 0;
}