#include <stdio.h>
#include <ctype.h>

int main(void)
{
 char ch;
 int vowelLetter = 0;

 printf("Enter a sentence: \n");
 // scanf("%c", &ch);

 while ((ch = getchar()) != '\n')
 {
  switch (toupper(ch))
  {
  case 'A':
  case 'E':
  case 'I':
  case 'O':
  case 'U':
   vowelLetter++;
   break;
  }
 }
 printf("Your sentence contains %d vowels.\n", vowelLetter);

 return 0;
}