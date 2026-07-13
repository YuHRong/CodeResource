// Write a C program to convert a given integer (in seconds) to hours, minutes and seconds.

#include <stdio.h>

int main(void)
{
 int input_second, result, hours, minutes, seconds;
 hours = 0, minutes = 0, seconds = 0;

 printf("Input seconds: ");
 scanf("%d", &input_second);

 result = input_second;
 hours = result / 3600;

 result = input_second % 3600;
 minutes = result / 60;

 result = result % 60;
 seconds = result;

 printf("There are: \n");
 printf("H:M:S - %d:%d:%d\n", hours, minutes, seconds);

 return 0;
}