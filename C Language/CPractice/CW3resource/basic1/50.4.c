// Write a C program to find and display the positions and values of prime numbers within an array.

#include <stdio.h>
#include <stdbool.h>

#define SIZE 7

bool isPrime(int n);

int main(void)
{
 int arr[SIZE];

 printf("Input %d numbers of the array\n", SIZE);
 for (int i = 0; i < SIZE; i++)
  scanf("%d", &arr[i]);

 for (int i = 0; i < SIZE; i++)
 {
  if (isPrime(arr[i]))
   printf("A[%d] = %d\n", i, arr[i]);
 }

 return 0;
}

// 质数函数定义
bool isPrime(int n)
{
 if (n <= 1)
  return false; // 1不是质数
 if (n == 2)
  return true; // 2是最小的质数

 if (n % 2 == 0)
  return false; // 偶数不是质数

 for (int i = 3; i * i <= n; i += 2)
 {
  if ((n % i) == 0)
   return false; // 如果能被i整除，不是质数
 }

 return true; // 否则是质数
}