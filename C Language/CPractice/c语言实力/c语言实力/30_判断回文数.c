 #define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void) {
 int n, remainder, originalInteger, reversedInteger = 0;


 printf("输入一个整数： ");
 scanf("%d", &n);

 originalInteger = n;
// 翻转
 while (n != 0) {
  remainder = n % 10;
  reversedInteger = reversedInteger * 10 + remainder;
  n /= 10;
 }

 // 判断
 if (originalInteger == reversedInteger)
 {
  printf("%d 是回文数\n", originalInteger);

 }
 else
 {
  printf("%d 不是回文数\n", originalInteger);
 }
      
 return 0;
}