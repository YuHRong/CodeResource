#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int limit;

 // 提示用户输入次数
 printf("输入你想要的次数: \n");

 while (scanf("%d", &limit) == 1 && limit > 0)
 {
  // 初始化球和变量
  double sum = 0, den = 1.0;

  // 计算第一个无限序列总和
  for (int i = 0; i < limit; i++)
  {
   sum += 1.0 / den++;
  }

  // 打印第一个无限序列总和的结果
  printf("1.0 + 1.0 / 2.0 + 1.0 / 3.0 + 1.0 / 4.0 +... + 1.0 / %d = %f\n", limit, sum);

  sum = 0, den = 1.0;
  // 计算第二个无限序列总和
  for (int i = 0; i <= limit; i++)
  {
   // 对符号进行设置
   int sign = 1;
   if (i % 2 != 0)
   {
    sign = -1;
   }
   sum += sign * (1.0 / den++);
  }

  // 打印第二个无限序列总和的结果
  printf("1.0 - 1.0 / 2.0 + 1.0 / 3.0 - 1.0 / 4.0 +... + 1.0 / %d = %f\n", limit, sum);

  // 提示用户再次输入次数
  printf("输入下一个循环次数，输入 0 或输入 复数退出：");
 }

 return 0;
}