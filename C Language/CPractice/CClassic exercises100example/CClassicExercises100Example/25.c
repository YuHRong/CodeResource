// 求 1 + 2! + 3! + ... + 20! 的和。

#include <stdio.h>

unsigned long long fibonacci(int n);

int main(void)
{
 unsigned long long sum = 0;

 // 计算前20像阶乘的和
 for (int i = 1; i <= 20; i++)
  sum += fibonacci(i);
 printf("1 + 2! + 3! + ... + 20!的和是: %llu\n", sum);

 return 0;
}

unsigned long long fibonacci(int n)
{
 unsigned long long result = 1;
 for (int i = 1; i <= n; i++)
  result *= i;
 return result;
}