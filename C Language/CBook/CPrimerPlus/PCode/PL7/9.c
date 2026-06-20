#include <stdio.h>
#include <stdbool.h>

int main(void)
{
 int limit, num, div;
 bool numIsPrime; // 素数标识

 // 提示用户输入一个正整数
 printf("Enter a positive integer:");
 while (scanf("%d", &limit) == 1 && limit > 0)
 {
  if (limit > 1)
   printf("Here are the prime numbers up through %d\n", limit);
  else
   printf("No primes.\n");

  // 循环判断是否为素数
  for (num = 2; num <= limit; num++)
  {
   for (div = 2, numIsPrime = true; (div * div) <= num; div++)
   {
    // 如果能整除就不是素数，设置numIsPrime为false

    if (num % div == 0)
     numIsPrime = false;
   }

   // 显示素数
   if (numIsPrime)
    printf("%d is prime.\n", num);
  }
  printf("Enter next positive integer (q to quit):");
 }
 printf("Done!\n");

 return 0;
}