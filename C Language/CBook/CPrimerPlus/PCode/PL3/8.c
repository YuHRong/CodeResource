#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 double pint, cup, ounce;
 double large_soup_spoon, tea_spoon;

 printf("请输入杯数:\n");
 scanf("%lf", &cup);
 pint = cup / 2;  // 计算品脱
 ounce = cup * 8;  // 计算盎司
 large_soup_spoon = ounce * 2;  // 计算大汤勺
 tea_spoon = large_soup_spoon * 3;  // 计算茶勺

 printf("%.2lf 杯\n= %.2lf 品脱\n= %.2lf 盎司\n= %.2lf 大汤勺\n= %.2lf 茶勺",
  cup, pint, ounce, large_soup_spoon, tea_spoon);

 return 0;
}