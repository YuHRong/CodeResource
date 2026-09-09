// Write a program that reads two numbers and divides the first number by the second number. If division is not possible print "Division is not possible".

#include <stdio.h>

int main()
{
 float x, y, result;

 printf("Enter two numbers:\n");
 printf("x : ");
 scanf("%f", &x);
 printf("y : ");
 scanf("%f", &y);

 if (y == 0)
 {
  printf("Division not possible.\n");
  return 1;
 }
 else
 {
  result = x / y;
 }
 printf("%.1f\n", result);

 return 0;
}