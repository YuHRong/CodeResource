/* addemup.c -- 几种常见的语句 */
#include<stdio.h>

int main(void) {
 int count, sum;    // 先申明[1]
 count = 0;    // 表达式语句
 sum = 0;        // 表达式语句
 while (count++ < 20)    //迭代语句
  sum = sum + count;
 printf("sum = %d\n", sum);    // 新表达式语句[2]

 return 0;    // 跳转语句
}