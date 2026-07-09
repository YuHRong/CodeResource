#include<stdio.h>

int main(void)
{
 int m = 10;
 int n, o;
 int * z;
 z = &m;


 printf("z stores the address of m = %p\n", (void*)z);
 printf("*z stores the value of m = %d\n", *z);

 printf("&m is the address of m = %p\n", (void*)&m);

 printf("&n stores the address of n = %p\n", (void*)&n);

 printf("&o stores the address of o = %p\n", (void*)&o);

 printf("&z stores the address of z = %p\n", (void*)&z);

 return 0;
}