#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void) {
 char letter;

 printf("输入 u 输出大写字母，输入 l 输出小写字母： ");
 scanf("%c", &letter);

 if (letter == 'u' || letter == 'U') {
  for (letter = 'A'; letter <= 'Z'; letter++)
   printf("%c ", letter);
 }
 else if (letter == 'l' || letter == 'L') {
  for (letter = 'a'; letter <= 'z'; letter++)
   printf("%c ", letter);
 }
 else
 {
  printf("Error: 输入非法字符。");
 }

 return 0;
}