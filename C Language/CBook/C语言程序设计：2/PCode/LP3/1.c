#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int year, month, day;

 printf("Enter a date (mm/dd/yyyy): ");
 scanf("%d/%d/%d", &month, &day, &year);
 printf("You entered the date %d%.2d%d\n", year, month, day);

 return 0;
}