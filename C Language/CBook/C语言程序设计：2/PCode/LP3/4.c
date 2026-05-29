#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>


int main(void)
{
 int num1, num2;

 printf("Enter phone number [(xxx) xxx-xxxx]: (404)");
 scanf("%d-%d", &num1, &num2);
 printf("You entered 404.%d.%d\n", num1, num2);

 return 0;
}