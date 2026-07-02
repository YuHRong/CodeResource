#include <stdio.h>
#include <ctype.h>

int locat(int ch);

int main(void)
{
 char ch;

 printf("Enter a locat: \n");
 while ((ch = getchar()) != '\n')
 {
  if (isalpha(ch))
  {
   printf("The location of %c in alphabet is %d.\n", ch, locat(ch));
  }

  while (getchar() != '\n')
   continue;

  printf("Enter next character (a newline to quit):");
 }
 printf("Bye");

 return 0;
}

int locat(int ch)
{
 // 如果不是字母，返回-1
 int index = -1;

 // 如果是字母
 if (isalpha(ch))
 {
  // 将字母转转换为小写，然后减去第一个字母在减1
  index = tolower(ch) - 'a' + 1;
 }

 return index;
}