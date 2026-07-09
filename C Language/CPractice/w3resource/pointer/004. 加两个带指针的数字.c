/*
  用C语言写一个程序，用指针加两个数字。
 测试数据：
 输入第一个数字：5
输入第二个数字：6
*/

#include <stdio.h>

int main(void)
{
 // 申明整数变量： n1, n2, 和整数指针 p1, p2
 int n1, n2, *p1, *p2, sum;

 printf("\n\n Pointer : Add two numbers :\n");
 printf("--------------------------------\n");

 printf("Enter the first number:");
 scanf("%d", &n1);

 printf("Enter the second number:");
 scanf("%d", &n2);

 // 将 n1 的指针地址分配给 p1
 p1 = &n1;
 // 将 n2 的指针地址分配给 p2
 p2 = &n2;

 // 取消引用 p1 和 p2 以获取值并计算它们的和
 sum = *p1 + *p2;

 printf(" The sum of the entered numbers is : %d\n\n", sum);

 return 0;
}