#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
int main(void) {
 float p = 0;

 printf("Enter a floating-point value:  64.25");
 scanf("%f", &p);
 printf("fised-point notation: %f\n", p);
 printf("exponential notation: %e\n", p);
 printf("p notation: %.2a\n", p);

 return 0;
}