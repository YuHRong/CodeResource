// Write a C program to check whether a given integer is positive even, negative even, positive odd or negative odd. Print even if the  is 0.

#include <stdio.h>

int main()
{
 int n;

 printf("Input an integer:");
 int i = scanf("%d", &n);

 // 检查输入的是否是数字
 if (i != 1)
 {
  printf("Error: Enter intger, please\n");
  return 1; // 如果不是数字报错并退出程序
 }

 if (n == 0)
 {
  printf("Even\n");
 }
 else if ((n % 2) == 0) // 判断正偶数付偶数
 {
  if (n > 0)
   printf("Positive even\n");
  else
   printf("Negative even\n");
 }
 else // 判断正正奇数付奇数
 {
  if (n > 0)
   printf("Positive odd\n");
  else
   printf("Negative odd\n");
 }

 return 0;
}