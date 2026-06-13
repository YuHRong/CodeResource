#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void) {
 long long n;
 int count = 0;

 printf("输入一个整数: ");
 scanf("%lld", &n);

 while (n != 0) {
  // n = n/10
  n /= 10;
  count++;
 }
 printf("数字是 %d 位数。", count);

 return 0;
}