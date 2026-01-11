// when.c -- 何时退出循环
#include<stdio.h>
int main(void) 
{
 int n = 5;

 while (n < 7)        // 第7行
 {
  printf("%d\n", n);
  n++;            // 第10行
  printf("Now n =%d\n", n);     //第11行
}
 printf("The loop has finished.\n");

 return 0;
}