// 获取贷款金额并计算前三个月还款后剩余的还款额
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 float amount_of_loan, rate, monthly_rate, monthly_payment, first_payment, second_payment, third_payment;

 printf("Enter amount of loan: ");
 scanf("%f", &amount_of_loan);

 printf("Enter interest rate: ");
 scanf("%f", &rate);

 printf("Enter monthly payment: ");
 scanf("%f", &monthly_payment);

 monthly_rate = rate / 100.00f / 12.0f;

 first_payment = amount_of_loan - monthly_payment + (amount_of_loan * monthly_rate);
 printf("Balance remaining after first payment: $%.2f\n", first_payment);

 second_payment = first_payment - monthly_payment + (first_payment * monthly_rate);
 printf("Balance remaining after second payment: $%.2f\n", second_payment);

 third_payment = second_payment - monthly_payment + (second_payment * monthly_rate);
 printf("Balance remaining after third payment: $%.2f  \n", third_payment);

 return 0;
}