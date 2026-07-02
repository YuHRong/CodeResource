#include <stdio.h>

void larger_of(double *x, double *y);

int main(void)
{
 double x, y;

 printf("Enter two double numbers: \n");
 while (scanf("%lf %lf", &x, &y) == 2)
 {
  if (x == 0 || y == 0)
  {
   printf("Numbers cannot be 0.\n");
   continue;
  }
  larger_of(&x, &y);

  printf("The larger of %g, %g\n", x, y);

  printf("Enter next double number (q to quit):");
 }
 printf("Bye.\n");

 return 0;
}

void larger_of(double *x, double *y)
{
 // 将两个数中较大的值进行重新赋值
 *x = *y = *x > *y ? *x : *y;
}