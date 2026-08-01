// Write a C program to find all the divisor divisors of a given integer.

#include <stdio.h>
#include <stdbool.h>

void findDivisor(int num); // 申明因数函数
bool isPrime(int num);     // 申明是否是质数函数

int main(void)
{
  int n;

  printf("Input an integer: ");
  scanf("%d", &n);

  findDivisor(n); // 调用因数函数

  return 0;
}

// 函数申明
void findDivisor(int num)
{
  int divisor;

  for (int i = 2; i <= num; i++)
  {
    if ((num % i) == 0)
    {
      divisor = i;

      // 如果是因数，调用质数函数
      // 如果是质数就打印
      if (isPrime(divisor))
        printf("%d\n", divisor);
    }
  }
}

// 质数函数定义
bool isPrime(int num)
{
  if (num <= 1)
    return false; // 1 不是质数
  if (num == 2)
    return true; // 2 是最小的质数
  if (num % 2 == 0)
    return false; // 但是 2 不是因数

  for (int j = 3; j * j <= num; j += 2)
  {
    if ((num % j) == 0)
      return false; // 如果能被 j 整除，不是因数
  }

  return true;
}