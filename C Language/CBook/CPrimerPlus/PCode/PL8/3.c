/*
使用 isupper() 函数读取大写字母。
使用 islower() 函数读取小写字母
*/

#include <stdio.h>
#include <ctype.h>

int main(void)
{
  int ch;
  long upperCount = 0, lowerCount = 0, otherCount = 0;

  printf("Please enter chars (& to quit): \n");
  while ((ch = getchar()) != EOF)
  {
    if (isupper(ch))
      upperCount++;
    else if (islower(ch))
      lowerCount++;
    else
      otherCount++;
  }

  printf("\n%ld uppercase characters read\n", upperCount);
  printf("%ld lowercase characters read\n", lowerCount);
  printf("%ld other characters read\n", otherCount);

  return 0;
}