#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int n;
 double evenSum = 0;
 int evenCount = 0;
 double oddSum = 0;
 int oddCount = 0;

 // 提示输入整数，直到0结束
 printf("Please input integer numbers (0 to quit):\n");
 while (scanf("%d", &n) == 1 && n != 0)
 {
  // 计算偶数的个数、偶数和
  if (n % 2 == 0)
  {
   evenSum += n;
   evenCount++;
  }
  else
  {
   // 计算奇数的个数、奇数和
   oddSum += n;
   oddCount++;
  }
 }

 // 打印偶数个数
 printf("Number of evens: %d,", evenCount);
 if (evenCount > 0)
 {
  // 打印偶数平均值
  printf(" average: %g\n", evenSum / evenCount);
 }

 // 打印奇数个数
 printf("Number of odds: %d,", oddCount);
 if (oddSum > 0)
 {
  // 打印奇数的平均值
  printf(" average: %g\n", oddSum / oddCount);
 }
 printf("Done\n");

 return 0;
}