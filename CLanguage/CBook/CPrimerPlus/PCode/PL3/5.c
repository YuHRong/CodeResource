#include<stdio.h>

int main(void) {
 int age;
 float second;

 printf("Please enter your age:");
 scanf_s("%d", &age);
 second = age * 3.156e7;
 printf("Your age scond is: %e\n", second);
 return 0;
}