#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#define DAY_WEEK 7    // 每周的天数

int main(void)
{
 int weeks, days, left;

 printf("请输入天数,输入 0 退出:\n");
 scanf("%d", &days);
 while (days > 0)
 {
  weeks = days / DAY_WEEK;
  left = days % DAY_WEEK;
  printf("%d days are %d weeks, %d days.\n", days, weeks, left);
  printf("请输入天数，输入0退出:\n");
  scanf("%d", &days);
 }
 printf("Bye.\n");

 return 0;
}