// Write a C program to calculate the distance between two points.

#include <stdio.h>
#include <math.h>

int main()
{
 double x1, x2, y1, y2;
 double sum = 0;

 printf("input x1: ");
 scanf("%lf", &x1);
 printf("Input y1: ");
 scanf("%lf", &y1);

 printf("Input x2: ");
 scanf("%lf", &x2);
 printf("Input y2: ");
 scanf("%lf", &y2);

 sum = sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

 // double x_sum = pow((x2 - x1), 2);
 // double y_sum = pow((y2 - y1), 2);
 // sum = sqrt(x_sum + y_sum);

 printf("Distance between the said points: %.4f\n", sum);

 return 0;
}