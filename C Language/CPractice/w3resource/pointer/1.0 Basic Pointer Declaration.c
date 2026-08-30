// Write a program in C to show the basic declaration of a pointer.
#include <stdio.h>

int main(void)
{
 int m = 10, n, o;
 int *z = &m;

 printf("\nPointer : Show the basic declaration of pointer : \n");
 printf("------------------------------------------------------- \n");
 printf("-------------------------------------------------------\n");
 printf(" Here is m=10, n and o are two integer variable and *z is an integer");

 printf("\nz stores the address of m = %p\n", (void *)z);

 printf("\n*z stores the value of m = %d\n", *z);

 printf("\n&m is the address of m = %p\n", (void *)&m);

 printf("\n&n stores the address of n = %p\n", (void *)&n);

 printf("\n&o stores the address of o = %p\n", (void *)&o);

 printf("\n&z stores the address of z = %p\n", (void *)&z);

 return 0;
}