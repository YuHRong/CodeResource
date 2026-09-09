// Write a program in C to find the maximum number between two numbers using a pointer.
#include <stdio.h>

int main()
{
 int n1, n2, t;
 int *p1 = &n1, *p2 = &n2;

 printf("Input the first number: \n");
 scanf("%d", &p1);
 printf("Input the Second number: \n");
 scanf("%d", &p2);

 if (*p1 > *p2)
  printf("%i is the maximum number.\n", *p1);
 else
  printf("%i is the maximum number.\n", *p2);

 return 0;
}