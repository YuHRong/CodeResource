// Write a C program that reads 5 numbers, counts the number of positive numbers, and prints out the average of all positive values.
int count = 0, sum = 0;
#include <stdio.h>

int main()
{
 float n[5];
 int count = 0, sum = 0;
 float avg;

 printf("Input the first number: ");
 scanf("%f", &n[0]);
 printf("Input the second number: ");
 scanf("%f", &n[1]);
 printf("Input the third number: ");
 scanf("%f", &n[2]);
 printf("Input the four number: ");
 scanf("%f", &n[3]);
 printf("Input the fifth number: ");
 scanf("%f", &n[4]);

 for (int i = 0; i < 5; i++)
 {
  if (n[i] > 0)
  {
   count++;
   sum += n[i];
  }
 }

 avg = sum / count;

 printf("Number of positive numbers: %f\n", count);
 printf("Average value of the said positive numbers: %.2f\n", avg);

 return 0;
}