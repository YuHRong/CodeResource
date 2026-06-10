/* 输入24小时至格式，以12小时制格式显示 */
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int hour, minute;

 printf("Enter a 24-hour time: ");
 scanf("%d:%d", &hour, &minute);

 switch (hour)
 {
 case 13: hour = 1; break;
 case 14: hour = 2; break;
 case 15: hour = 3; break;
 case 16: hour = 4; break;
 case 17: hour = 5; break;
 case 18: hour = 6; break;
 case 19: hour = 7; break;
 case 20: hour = 8; break;
 case 21: hour = 9; break;
 case 22: hour = 10; break;
 case 23: hour = 11; break;
 case 24: hour = 12; break;
 }
 printf("Equivalent 12-hour time: %d:%d PM\n", hour, minute);

 return 0;
}