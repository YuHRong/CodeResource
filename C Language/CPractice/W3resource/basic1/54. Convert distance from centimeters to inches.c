// Write a C program that accepts a distance in centimeters and prints the corresponding value in inches.

#include <stdio.h>

int main(void)
{
 const double cm_inch = 2.54;
 double cm, inch;

 printf("Input the distance in cm: ");
 scanf("%lf", &cm);

 inch = cm / cm_inch;

 printf("Distance of %.2lf cms is = %.2lf inches\n", cm, inch);

 return 0;
}