#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int num;

 printf("请输入一个数字： ");
 scanf("%d", &num);

 if (num % 2 == 0)
  printf("%d 是偶数\n", num);
 else
  printf("%d 是基数\n", num);

 return 0;
}