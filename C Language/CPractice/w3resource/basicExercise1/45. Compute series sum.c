// Compute series sum S=1+1/2+1/3+...+1/50
// Write a C program to calculate the value of S where S = 1 + 1/2 + 1/3 + … + 1/50.

/*
 循环条件，i=1
i <= 50
i++
循环体
sum += (1.0 /i)
*/

#include <stdio.h>

int main()
{
 float sum = 0.0;

 for (int i = 1; i <= 50; i++)
 {
  sum += (float)1.0 / i;
 }

 printf("Value of S: %.2f\n", sum);

 return 0;
}