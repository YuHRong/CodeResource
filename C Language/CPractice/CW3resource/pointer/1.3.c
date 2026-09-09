// Write a C program to demonstrate pointer declaration by assigning addresses of several variables and printing both the addresses and values using dereferencing.

#include <stdio.h>

int main(void)
{
 int x = 10;
 float fx = 10.0f;
 char ch = 'z';
 int *px = &x;
 float *pfx = &fx;
 char *pch = &ch;

 printf("Value of the x =  %i\n", *px);
 printf("Address of the x = %p\n", (void *)px);

 printf("\nValue of the fx = %.2f\n", *pfx);
 printf("Address of the pfx : %p\n", (void *)pfx);

 printf("\nValue of the ch = %c\n", *pch);
 printf("Address of the ch : %p\n", (void *)pch);

 return 0;
}