// truth.c -- 哪些值为真
#include<stdio.h>
int main(void) 
{
 int n = 3;

 while (n)
  printf("%2d is true\n", n--);
  printf("%2d is false\n", n);

  n = -3;
  while (n)
   printf("%2d is true\n", n++);
  printf("%2d is false\n", n);

  return 0;
}