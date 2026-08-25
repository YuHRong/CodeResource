// Write a C program to shift given data by two bits to the left.

#include <stdio.h>

int main(void)
{
 int n, m;

 printf("Read the integer from keyboard : ");
 scanf("%d", &n);

 printf("Integer value = %d\n", n);

 n <<= 2;
 m = n;

 printf("The left shifted data is = %d ", m);

 return 0;
}