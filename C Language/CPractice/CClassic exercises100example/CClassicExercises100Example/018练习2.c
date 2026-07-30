/*
求 s=a+aa+aaa+aaaa+aa...a 的值，
其中 a 是一个数字，
例如 2+22+222+2222+22222  (此时共有5个数相加)，
几个数相加由键盘控制。
使用递归实现
*/

#include <stdio.h>

// 递归函数，用于计算每一项的值
int calculateTerm(int n, int a);

int main(void)
{
 // a 初始值， n 总箱数, sum 累加结果
 int a, n, sum = 0;

 printf("请输入初始值： ");
 scanf("%d", &a);
 printf("请输入总项数： ");
 scanf("%d", &n);

 // 验证输入
 if (a <= 0 || n <= 0)
 {
  printf("输入的初始值和项数必须为正整数！\n");
  return 1;
 }

 // 通过循环累加每一项
 for (int i = 1; i <= n; i++)
 {
  sum += calculateTerm(i, a);    // 调用递归函数计算第 i 项的值
 }
 printf("计算结果为：%d\n", sum);

 return 0;
}

// 递归函数，计算当前项的值
int calculateTerm(int n, int a)
{
 if (n == 1)
 {
  return a; // 递归终止条件，第一项直接返回 a
 }
 else
 {
  // 递归计算：当前项等于上一项乘以 10 加 a
  return calculateTerm(n - 1, a) * 10 + a;
 }
}