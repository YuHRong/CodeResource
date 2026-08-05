#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int dayMonth, startWeek;

 printf("Enter number of days in month: ");
 scanf("%d", &dayMonth);
 printf("Enter starting day of the week (1=Sun, 7=Sat): ");
 scanf("%d", &startWeek);

 int day = 1;
 int n = dayMonth + (startWeek - 1);

 for (int i = 1; i <= n; i++)
 {
  if (i < startWeek) {
   printf("   ");
  }
  else {
   printf("%3d", day++);
  }

  if (i % 7 == 0)
   printf("\n");
 }

 return 0;
}