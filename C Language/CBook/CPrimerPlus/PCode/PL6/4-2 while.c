#include<stdio.h>
int main(void)
{
 int i = 1; 
 char ch = 'A';
 while (i <= 6)
 {
  int j = 1;
  while (j <= i)
  {
   printf("%c", ch);
   ch++;
   j++;
  }
  printf("\n");
  i++;
 }

 return 0;
}