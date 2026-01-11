/* rows1.c -- 使用嵌套循环 */
#include<stdio.h>
#define ROWS 6
#define CHARS 10
int main(void) 
{
 int row;
 char ch;
 for (row = 0; row < ROWS; row++)      // 第10行
 {
  for (ch = 'a'; ch < ('a' + CHARS); ch++)    // 第12行
   printf("%c", ch);
  printf("\n");
 }
 return 0;
}