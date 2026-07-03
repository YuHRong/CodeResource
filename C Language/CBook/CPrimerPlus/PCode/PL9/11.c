/*
程序分析： 
斐波那契数列：
a = 1,
b = 1,
c = a + b = 2,
d(a) = c + b = 3,
以此类推。
先使用循环输出斐波那契数列
int a = 1;
int b = 1;
int c = 0;
for(int i = 3; i <= n; i++)
{
c = a + b;
a = b;
b = c;
}
*/

#include <stdio.h>

int  fibonacci(int n);

int main(void)
{
 int n;

 printf("Enter an integer: \n");
 while (scanf("%d", &n) == 1)
 {
  fibonacci(n);

  printf("Enter next an integer(q to quit): \n");
 }
 printf("Done.\n");

 return 0;
}

int fibonacci(int n)
{
 // 若输入小于等于 0
 if (n <= 0)
 {
  printf("Please enter a positive integer.\n");
  return 0;
 }

 // 若输入为 1
 if (n == 1)
 {
  printf("1 \n");
  return 1;
 }

 // 若输入为 2
 if (n == 2)
 {
  printf("1 1 \n");
  return 1;
 }

 
 // 输入大于等于 3
 // 打印前两项
 printf("1 1 ");
 int a = 1, b = 1, c = 0;

 for (int i = 3; i <= n; i++)
 {
  c = a + b;
  a = b;
  b = c;
  printf("%d ", c);
 }
 printf("\n");

 return c;
}