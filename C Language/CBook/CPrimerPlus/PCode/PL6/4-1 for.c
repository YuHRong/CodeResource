#include<stdio.h>
int main(void)
{
 char;
 for (int i = 0, ch = 'A'; i < 6; ++i)
 {
  for (int j = 0; j <= i; ++j)
  {
   printf("%c", ch++);
  }
  printf("\n");
 }
 return 0;
}