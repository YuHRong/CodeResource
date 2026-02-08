#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int first, second, result;

 printf("This program computes moduli.\n");
 printf("Enter an integer to serve as the second operand:");
 scanf("%d", &second);

 printf("Now enter the first operand:");
 scanf("%d", &first);

 while (first > 0)
 {
  result = first % second;
  printf("%d %% %d is %d\n", first, second, result);
  printf("Enter next number for first operand(<= 0 to quit) :");
  scanf("%d", &first);
 }
 printf("Done\n");
 return 0;
}