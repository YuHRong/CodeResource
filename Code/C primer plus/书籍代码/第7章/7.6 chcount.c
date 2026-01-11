// chcount.c  -- 使用逻辑与运算符
#include<stdio.h>
#define PERIOD '.'
int main(void) 
{
 char ch;
 int charCount = 0;
 while ((ch = getchar()) != PERIOD)
 {
  if (ch != '"' && ch != '\'')
   charCount++;
 }
 printf("There are %d non-quote characters.\n", charCount);
 return 0;
}