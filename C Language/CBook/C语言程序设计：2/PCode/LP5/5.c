#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void) {
 double incomeDollar, tax;

 printf("plase enter your incomes: ");
 scanf("%lf", &incomeDollar);

 if (incomeDollar <= 750) {
  tax = incomeDollar * 0.01;
  printf("Your income is $%.2lf, taxes are $%.2lf\n", incomeDollar, tax);
 }
 else if (incomeDollar <= 2250) {
  tax = 7.5 + (incomeDollar - 750) * 0.02;
  printf("Your income is $%.2lf, taxes are $%.2lf\n", incomeDollar, tax);
 }
 else if (incomeDollar <= 3750) {
  tax = 37.50 + (incomeDollar - 2250) * 0.03;
  printf("Your income is $%.2lf, taxes are $%.2lf\n", incomeDollar, tax);
 }
 else if (incomeDollar <= 5250) {
  tax = 82.50 + (incomeDollar - 3750) * 0.04;
  printf("Your income is $%.2lf, taxes are $%.2lf\n", incomeDollar, tax);
 }
 else if (incomeDollar <= 7000) {
  tax = 142.5 + (incomeDollar - 5250) * 0.05;
  printf("Your income is $%.2lf, taxes are $%.2lf\n", incomeDollar, tax);
 }
 else {
  tax = 230 + (incomeDollar - 7000) * 0.06;
  printf("Your income is $%.2lf, taxes are $%.2lf\n", incomeDollar, tax);
 }

 return 0;
}