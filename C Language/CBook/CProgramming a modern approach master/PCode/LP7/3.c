/* Sums a series of numbers (using long int variables) */
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void) {
 double n, sum = 0.0f;

 printf("This program sums a series of integers.\n");
 printf("Enter integers (0 to terminate): ");
 scanf("%lf", &n);

 while (n != 0) {
  sum += n;
  scanf("%lf", &n);
 }
printf("The sum is: %lf\n", sum);

return 0;
}