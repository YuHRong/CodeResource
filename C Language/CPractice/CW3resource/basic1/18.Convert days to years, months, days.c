// Write a C program to convert a given integer (in days) to years, months and days, assuming that all months have 30 days and all years have 365 days.

#include <stdio.h>

int main(void)
{
 int input, y, m, d, r;

 printf("Input no. of days: ");
 scanf("%d", &input);

 r = input;
 y = r / 365;

 r = r % (y * 365);
 m = r / 30;

 r = r % (m * 30);
 d = r;

 printf("%d Year(s)\n", y);
 printf("%d Month(s)\n", m);
 printf("%d Day(s)\n", d);

 return 0;
}