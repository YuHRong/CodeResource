// Write a C program that finds all the divisors of an integer.

#include <stdio.h>

int main(void)
{
 int n;

 printf("Input an intger: ");
 scanf("%d", &n);

 printf("All the divisor of %d are:\n", n);
 // 循环便利从1到输入的值
 for (int i = 1; i <= n; i++)
 {
   // 使用获取的值求余
  if ((n % i) == 0)
  { // 如果 n % i 等于0，就是因数并打印
   printf("%d\n", i);
  }
 }

 return 0;
}