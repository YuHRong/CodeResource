#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 static int i;   //static静态局部变量
 int j = 4;

 printf("请输入:\n");
 scanf("%d %d", &i, &j);
 printf("%d\n", i * j);

 return 0;
}