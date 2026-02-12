#include<stdio.h>
int main(void)
{ 
 int i = 0;

 while (i++ < 6)
 {
  int j = 0;
  char ch = 'F';
  while (j++ < i)
  {
   printf("%c", ch--);
  }
  printf("\n");
 }
 return 0;
}