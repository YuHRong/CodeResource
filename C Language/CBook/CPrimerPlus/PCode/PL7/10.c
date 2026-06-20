#include <stdio.h>

#define AMT1 17850 // 单身
#define AMT2 23900 // 户主
#define AMT3 29750 // 已婚、共有
#define AMT4 14875 // 已婚、离异

#define RATE1 0.15
#define RATE2 0.28

void selectMenu();
void calc(double amt, double salary);

int main(void)
{
 int payLevel;
 double salary, pay;

 selectMenu();
 while ((scanf("%d", &payLevel)) == 1 && payLevel != 5)
 {
  switch (payLevel)
  {
  case 1:
   pay = AMT1;
   break;
  case 2:
   pay = AMT2;
   break;
  case 3:
   pay = AMT3;
   break;
  case 4:
   pay = AMT4;
   break;

  default:
   printf("Please enter choice 1~5 .\n");
   selectMenu();
   continue;
  }

  printf("Enter your salary:");
  scanf("%lf", &salary);

  // 计算税金
  calc(pay, salary);

  selectMenu();
 }
 printf("Done.\n");

 return 0;
}

void selectMenu()
{
 printf("*****************************************************************\n");
 printf("Enter the number corresponding to the category or action:\n");
 printf("1) unmarried                            \n2) householder\n");
 printf("3) married, owned by all                \n4) married, divorced\n");
 printf("5) quit\n");
 printf("*****************************************************************\n");
}

void calc(double amt, double salary)
{
 double taxes;

 if (salary <= amt)
 {
  taxes = salary * RATE1;
 }
 else
 {
  taxes = amt * RATE1 + (salary - amt) * RATE2;
 }
 printf("The taxes is $%.2f.\n", taxes);
}