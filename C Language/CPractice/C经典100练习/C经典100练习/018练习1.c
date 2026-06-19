/*
 求 s=a+aa+aaa+aaaa+aa...a 的值，
 其中 a 是一个数字，
 例如 2+22+222+2222+22222  (此时共有5个数相加)，
 几个数相加由键盘控制。
*/

#include <stdio.h>

int main(void)
{
 int a, n, temp, sum = 0;

 printf("请输入整数 a 和 n（例如 2 和 5）：\n");
 scanf("%d %d", &a, &n);

 // 初始化 temp 为 a
 temp = a;

 // 通过循环计算 a + aa + aaa + ...
 while (n > 0)
 {
  sum += temp;    // 累加当前项
  a *= 10;   // a 每次左移一位，例如（2 -> 20 -> 200）
  temp += a;     // 更新 temp 位下一项
  n--;       // 减少剩余项
 }
 printf("计算结果为：%d\n", sum);

 return 0;
}