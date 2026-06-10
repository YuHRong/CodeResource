#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int a, b;

 printf("输入第一个数： ");
 scanf("%d", &a);

 printf("输入第二个数： ");
 scanf("%d", &b);

 if (a > b)
  printf("%d > %d\n", a, b);
 else
  printf("%d < %d\n", a, b);

 return 0;
}