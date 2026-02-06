#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#define HOUR_MINUTE 60    //每小时60分钟

int main(void)
{
 int min, hour, left;

 printf("请输入时间，以分钟为单位(<= 0 退出):\n");
 scanf("%d", &min);

 while (min > 0)
 {
  hour = min / HOUR_MINUTE;
  left = min % HOUR_MINUTE;
  printf("%d小时%d分钟\n", hour, left);
  printf("请输入时间，以分钟为单位:(<=0 退出):\n");
  scanf("%d", &min);
 }
 printf("再见!\n");

 return 0;
}