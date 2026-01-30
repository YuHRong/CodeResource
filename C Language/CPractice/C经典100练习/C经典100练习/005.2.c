#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
void s(int *a, int *b);
int main(void)
{
 int x, y, z;

 printf("请输入三个整数:\n");
 scanf("%d %d %d", &x, &y, &z);

 //交换顺序
 if (x > y)
  s(&x, &y);

 if (x >z)
  s(&x, &z);

 if (y > z)
  s(& y, & z);

 printf("%d, %d, %d\n", x, y, z);
 return 0;
}

void s(int *a, int *b)
{
 int t = *a;
 *a = *b;
 *b = t;
}