// 查找字符在字符串中出现的次数

#include <stdio.h>

int main(void)
{
 char s[1000], ch;
 int i, count = 0;

 printf("Input the string: \n");
 fgets(s, (sizeof s / sizeof s[0]), stdin);

 printf("Input the character to search for: ");
 scanf("%c", &ch);

 for (i = 0; s[i] != '\0'; ++i)
 {
  if (ch == s[i])
   ++count;
 }
 printf("The number of times the character %c appears in the string is %d\n", ch, count);

 return 0;
}