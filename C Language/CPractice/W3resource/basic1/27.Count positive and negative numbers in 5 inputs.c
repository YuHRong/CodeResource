// Write a C program that reads 5 numbers and counts the number of positive numbers and negative numbers.

#include <stdio.h>

int main()
{
 int n[5];
 int positive = 0, negative = 0;

 printf("Input the first number: ");
 scanf("%d", &n[0]);
 printf("Input the second number: ");
 scanf("%d", &n[1]);
 printf("Input the third number: ");
 scanf("%d", &n[2]);
 printf("Input the four number: ");
 scanf("%d", &n[3]);
 printf("Input the fifth number: ");
 scanf("%d", &n[4]);

 for (int i = 0; i < 5; i++)
 {
  if (n[i] > 0)
   positive++; // 递增证数
  else
   negative++; // 递增复数
 }

 printf("Number of positive numbers: %d\n", positive);
 printf("Number of negative numbers: %d\n", negative);

 return 0;
}