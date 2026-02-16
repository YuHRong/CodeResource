#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int i = 0;
 char ch;

 printf("请输入一个大写字母: ");
 scanf("%c", &ch);

 while (i++ < 5)
 {
  int j = 1, k = 5;
  int c = ch;
  while (k > c)
  {
   putchar(' ');    // 打印空格
   k--;
  }
  while (j < i)
  {
   printf("%c", c++);
   j++;
  }
  while (j > 0)
  {
   printf("%c", c--);
   j--;
  }
  printf("\n");
 }
 return 0;
}