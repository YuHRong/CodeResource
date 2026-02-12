#include<stdio.h>
int main(void)
{
 char ch[26];
 
 int i = 0;

 while (i < 26)
 {
  ch[i] = 'a' + i;
  i++;
 }

 i = 0;
 while (i < 26)
 {
  printf("%c ", ch[i]);
  i++;
 }
   printf("\n");

 return 0;
}