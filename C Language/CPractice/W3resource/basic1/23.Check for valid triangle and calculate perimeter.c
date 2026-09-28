// Write a C program that reads three floating-point values and checks if it is possible to make a triangle with them. Determine the perimeter of the triangle if the given values are valid.

#include <stdio.h>

int main(void)
{
 float a, b, c, Perimeter;

 printf("Check for valid triangle and calculate perimeter.\n");

 printf("Input the first number: ");
 scanf("%f", &a);
 printf("Input the second number: ");
 scanf("%f", &b);
 printf("Input the third number: ");
 scanf("%f", &c);

 if ((a + b) > c && (a + c) > b && (b + c) > a)
 {
  Perimeter = a + b + c;
  printf("Perimeter = %.1f\n", Perimeter);
 }
 else
 {
  printf("Not possible to create a triangle..!\n");
 }

 return 0;
}  