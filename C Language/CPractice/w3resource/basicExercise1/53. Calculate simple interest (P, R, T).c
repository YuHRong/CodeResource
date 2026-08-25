// Write a C program that accepts the principle, rate of interest, and time and calculates simple interest.

#include <stdio.h>

int main(void)
{
 double p, r, t, simpleInterest;

 printf("Input principle, Rate of interest & time to find simple interest:");
 scanf("%lf %lf %lf", &p, &r, &t);

 simpleInterest = (p * r * t) / 100;

 printf("Simple interest = %.2lf\n", simpleInterest);

 return 0;
}