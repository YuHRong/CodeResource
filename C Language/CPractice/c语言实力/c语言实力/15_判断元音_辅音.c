#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 char c;
 int lowercaseVowel, uppercaseVowel;

 printf("请输入一个字母： ");
 scanf("%c", &c);

 // 小写字母是原音
 lowercaseVowel = (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');

 // 大写字母是原音
 uppercaseVowel = (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U');

 // 判断
 if (lowercaseVowel || uppercaseVowel) printf("%c 是原音\n", c);
 else         printf("%c 是辅音", c);

 return 0;
}