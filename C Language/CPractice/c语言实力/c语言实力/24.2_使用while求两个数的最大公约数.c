#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int n1, n2;

 printf("输入两个正整数，以空格分割： ");
 scanf("%d %d", &n1, &n2);

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
 printf("gcd = %d\n", n1);

 return 0;
}