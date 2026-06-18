// 使用递归翻转字符串
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

void reverseSentence();

int main(void)
{
 printf("输入一个字符串: ");

 reverseSentence();

 return 0;
}

void reverseSentence()
{
 char c;

 scanf("%c", &c);

 if (c != '\n')
 {
  reverseSentence();

  printf("%c", c);
 }
}