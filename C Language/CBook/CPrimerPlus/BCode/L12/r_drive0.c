/* 12.8 r_drive0.c -- 测试 rand0()函数 */
/* 与 rand0.c 一起编译*/
#include<stdio.h>

extern unsigned int rand0(void);
int main(void)
{
 int count;
 for(count = 0; count < 5; count++)
  printf("%d\n", rand0());
 return 0;
}