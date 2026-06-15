#include<stdio.h>

int main(void)
{
 int j = 1, n = 3;

 for (int i = n; i <= (n * 10); i += n)
 {
  printf("%3d  x %2d  =  %3d\n", n, j, i);
  j++;
 }

 return 0;
}