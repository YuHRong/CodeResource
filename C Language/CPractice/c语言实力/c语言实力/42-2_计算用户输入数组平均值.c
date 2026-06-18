#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main()
{
 int n, i;
 float num[100], sum = 0.0, average;

 printf("Enter the number of elements: ");
 scanf("%d", &n);

 while (n > 100 || n <= 0)
 {
  printf("Error: The number needs to be between 1 and 100.");

  printf("Enter the number of elements: ");
  scanf("%d", &n);
 }

 for (i = 0; i < n; ++i)
 {
  printf("%d. Enter the number: ", i + 1);
  scanf("%f", &num[i]);

  sum += num[i];
 }
 average = sum / n;
 printf("Average = %.2f\n", average);

 return 0;
}