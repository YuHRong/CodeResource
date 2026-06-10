#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int a, b, c;

 printf("输入第一个数： ");
 scanf("%d", &a);
 printf("输入第二个数： ");
 scanf("%d", &b);
 printf("输入第三个数： ");
 scanf("%d", &c);

 if (a > b && a > c)
  printf("%d 最大\n", a);
 else if (a < b && b > c)
  printf("%d 最大\n", b);
 else if (a < c && b < c)
  printf("%d 最大\n", c);
 else
  printf("有两个或三个数相等\n");

 return 0;
}