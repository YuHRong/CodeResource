// 输入美元数量，计算 5% 的税率
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

#define TAX 0.05f

int main(void)
{
 float amount, addedTax;

 printf("Enter an amount: ");
 scanf("%f", &amount);
 addedTax = amount + amount * TAX;
 printf("with tax added: %.2f", addedTax);

 return 0;
}