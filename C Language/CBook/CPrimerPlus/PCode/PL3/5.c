#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void) {
 int age;
 float second;

 printf("Please enter your age:");
 scanf("%d", &age);
 second = age * 3.156e7;
 printf("Your age scond is: %e\n", second);
 return 0;
}