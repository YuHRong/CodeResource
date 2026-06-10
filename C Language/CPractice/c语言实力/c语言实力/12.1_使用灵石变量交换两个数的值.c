// 交换两个浮点数的值。
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)

double num1, num2, value;

 printf("请输入第一个数： ");
 scanf("%lf", &num1);
 printf("请输入第二个数： ");
 scanf("%lf", &num2);

 // 将 num1 赋值给 value
 value = num1;

 // 第二个数赋值给 num1
 num1 = num2;

 // 将 value 赋值给 num2
 num2 = value;

 printf("\n交换后, 第一个数字为 %.2lf\n", num1);
 printf("第二个数为 %.2lf\n", num2);

 return 0;
}