#include <stdio.h>

#define BASE_PAY 10    // 基本工资 10 美元/小时
#define OVER40HOURS 40 // 加班超过 40 小时
#define OVER40TIME 1.5 // 加班超过 40 小时为 1.5 倍
#define AMT1 300       // 前 300 美元
#define AMT2 150       // 续 150 美元
#define RATE1 0.15     // 前300美元的税率15%
#define RATE2 0.20     // 续150美元的税率为20%
#define RATE3 0.25     // 余下的税率为25%

int main(void)
{
 double hours;
 double wages, taxes, income;

 printf("Enter the number of hours worked this week: ");
 scanf("%lf", &hours);

 // 计算工资总额
 if (hours <= OVER40HOURS)
 {
  wages = hours * BASE_PAY;
 }
 else
 {
  wages = OVER40HOURS * BASE_PAY + (hours - OVER40HOURS) * OVER40TIME;
 }

 if (wages <= AMT1)
 {
  taxes = wages * RATE1;
 }
 else if (wages <= AMT1 + AMT2)
 {
  taxes = AMT1 * RATE1 + (wages - AMT1) * RATE2;
 }
 else
 {
  taxes = AMT1 * RATE1 + AMT2 * RATE2 + (wages - AMT1 - AMT2) * RATE3;
 }

 // 计算进收入
 income = wages - taxes;   

 printf("wages: $%.2f, taxes: $%.2f, income: $%.2f\n", wages, taxes, income);

 return 0;
}