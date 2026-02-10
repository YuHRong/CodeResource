#include<stdio.h>
#include<string.h>

int main(void)
{
 char ch[26];
 ch[0] = 'a';

 for (int i = 1; i < 26; i++)
 {
  ch[i] = 'a' + i;
 }
 for(int i = 0; i < 26; i++)
 {
  printf("%c ", ch[i]);
 }
 printf("\n");

 return 0;
}