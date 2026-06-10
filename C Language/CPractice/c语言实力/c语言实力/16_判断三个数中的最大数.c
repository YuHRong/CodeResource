#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int n1, n2, n3;

 printf("请输入三个数字，以空格分割： ");
 scanf("%d %d %d", &n1, &n2, &n3);

 if (n1 > n2 && n1 > n3)
  printf("%d 是最大数\n", n1);
 else if (n2 > n1 && n2 > n3)
  printf("%d 是最大数\n", n2);
 else
  printf("%d 是最大数\n", n3);

 return 0;
}