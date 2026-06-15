#include<stdio.h>

int main(void)
{
 int start, end, count;

 start = 2, end = 10;

 for (int i = start; i <= end; i++)
 {
  count = i;
  for (int j = 1; j <= 10; j++)
  {
   printf(" %3d", count * j);
  }
  printf("\n");
 }

 return 0;
}