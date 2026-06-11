#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int n1, n2;

 printf("输入两个数，以空格分割： ");
 scanf("%d %d", &n1, &n2);

 // 如果输入的是负数，将其转换为正数
 n1 = (n1 > 0) ? n1 : -n1;
 n2 = (n2 > 0) ? n2 : -n2;

 while (n1 != n2)
 {
  if (n1 > n2) 
  {
   n1 -= n2;
  }
  else
  {
   n2 -= n1;
  }
 }
 printf("GCD = %d", n1);

 return 0;
}