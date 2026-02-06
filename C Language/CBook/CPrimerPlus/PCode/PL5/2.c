#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#define N 10
int main(void)
{
 int num1;
 int num2;

 printf("请输入一个整数:\n");
 scanf("%d", &num1);
 num2 = num1 + N;

 while (num1 <= num2)
 {
  printf("%d ", num1);
  num1++;
 }
 return 0;
}