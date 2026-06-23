#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int hcf(int n1, int n2);

int main(void) {
 int n1, n2;

 printf("输入两个正整数，以空格分割： ");
 scanf("%d %d", &n1, &n2);

 printf("%d 和 %d 的最大公约数为 %d", n1, n2, hcf(n1, n2));

 return 0;
}

int hcf(int n1, int n2) 
{
 if (n2 != 0)
 {
  return hcf(n2, n1 % n2);
 }
 else
 {
  return n1;
 }
}