#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main(void) {
 int n, i;

 printf("请输入一个正整数：");
 scanf("%d", &n);

 printf("%d=", n);

 for (i = 2; i <= n; i++) {
  while (n % i == 0) {
   printf("%d", i);
   n /= i;
   if (n != 1) printf("*");
  }
 }
 printf("\n");

 return 0;
}