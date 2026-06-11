#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int n1, n2, m;

 printf("输入两个正整数： ");
 scanf("%d %d", &n1, &n2);

 // 判断两数较大的值并赋值给m
 m = (n1 > n2) ? n1 : n2;

 // 条件为 true
 while (1) 
 {
  if (m % n1 == 0 && m % n2 == 0)
  {
   printf("%d 和 %d 的最小公倍数是 %d\n", n1, n2, m);
   break;
  }
  ++m;
 }

 return 0;
}