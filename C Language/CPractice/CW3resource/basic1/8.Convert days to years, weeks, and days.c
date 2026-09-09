// Write a C program to convert specified days into years, weeks and days.
// Note: Ignore leap year.
#include <stdio.h>

int main(void)
{
 int years = 0, weeks = 0, days = 0, day;

 printf("Input number of days: \n");
 scanf("%d", &day);

 printf("Number of days : %d\n", day);

 years = day / 365;
 weeks = day % 365 / 7;
 days = day % 365 % 7;

 printf("years : %d\n", years);
 printf("weeks : %d\n", weeks);
 printf("days : %d\n", days);

 return 0;
}