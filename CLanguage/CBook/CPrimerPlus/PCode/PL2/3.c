//定义常量（年）为 365，
// 定义年龄变量。
//最后年龄乘以年。
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
int main(void)
{
 int age;
 const int year = 365;

 printf("请输入你的年龄\n");
 scanf("%d", &age);
 printf("你的年龄为: %d\n", age);
 printf("你的年龄对应天数为: %d\n", year * age);

 return 0;
}