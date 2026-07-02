#include <stdio.h>

void handle(double *n1, double *n2, double *n3);
void swap(double *x, double *y);

int main(void)
{
 double x, y, z;

 printf("Enter three double numbers: \n");
 while (scanf("%lf %lf %lf", &x, &y, &z) == 3)
 {
  handle(&x, &y, &z);

  printf("The values are %g, %g and %g.\n",
         x, y, z);
  printf("Next three values (q to quit):");
 }
 printf("Bye.\n");

 return 0;
}

void handle(double *n1, double *n2, double *n3)
{
 if (*n1 > *n2)
 {
  swap(n1, n2);
 }
 if (*n1 > *n3)
 {
  swap(n1, n3);
 }
 if (*n2 > *n3)
 {
  swap(n2, n3);
 }
}

void swap(double *x, double *y)
{
 double temp;

 temp = *x;
 *x = *y;
 *y = temp;
}