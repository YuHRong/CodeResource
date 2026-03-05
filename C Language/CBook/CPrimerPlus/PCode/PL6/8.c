#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 double num1, num2, result;

 // 输入两个浮点数
 printf("请输入两个浮点数: \n");
 while (scanf("%lf %lf", &num1, &num2) == 2)
 {
  // 计算两个数的差值除以两个数的乘机的结果
  result = (num1 - num2) / (num1 * num2);

  // 打印结果
  printf("(%.3g - %.3g) / (%.3g * %.3g) = %.5g\n", num1, num2, num1, num2, result);

  // 再次提示输入
  printf("输入下一组浮点数，不是数字时退出: \n");
 }
 printf("Done.");

 return 0;
}