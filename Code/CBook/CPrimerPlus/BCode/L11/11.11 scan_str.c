/* scan_str.c -- สนำร scanf() */
#include<stdio.h>

int main(void)
{
 char name1[11], name2[11];
 int count;

 printf("please enter 2 names.\n");
 count = scanf_s("%5s %10s", name1,(unsigned)sizeof(name1), name2,(unsigned)sizeof(name2));
 printf("I read the %d names %s and %s.\n", count, name1, name2);

 return 0;
}