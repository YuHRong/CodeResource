/* addemup.c -- 几种常见的语句 */
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void) {
 int day, count, sum;    // 先申明[1]
 count = 0;    // 表达式语句
 sum = 0;        // 表达式语句

 printf("请输入时间，单位天:\n");
 scanf("%d", &day);
 while (count++ < day)    //迭代语句
  sum = sum + count;
 printf("sum = %d\n", sum);    // 新表达式语句[2]

 return 0;    // 跳转语句
}