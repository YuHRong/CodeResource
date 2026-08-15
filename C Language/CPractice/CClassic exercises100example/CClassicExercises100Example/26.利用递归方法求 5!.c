// 利用递归方法求 5!。

#include <stdio.h>>

long factorial(int n);

int main(void)
{
 // 打印 1 到 5 的阶乘
 for (int i = 0; i < 6; i++)
  printf("%d! = %d\n", i, factorial(i));

 return 0;
}

long factorial(int n)
{
 int result;

 // 递归的条件
 if (n == 0)
 {
  result = 1; // 0 不等于 1
 }
 else
 {
  result = n * factorial(n - 1); // 递归计算 n! = n * (n-1)!
 }

 return result;
}