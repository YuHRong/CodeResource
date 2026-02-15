#include<stdio.h>

int main(void)
{
 int i, * p= & i;
 printf("i µÄÖµ: %d\n", *p);

 i = 1;
 printf("prints 1: %d\n", i);
 printf("prints 1: %d\n", *p);
 printf("\n");

 *p = 2;
 printf("prints 2: %d\n", i);
 printf("prints 2: %d\n", *p);
 printf("\n");

 //int* p;
 //printf("wrong: %d\n", *p);
 *p = 1;    //wrong

 return 0;
}