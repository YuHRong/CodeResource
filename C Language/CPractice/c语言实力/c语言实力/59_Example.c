// 计算字符串中的元音、辅音、数字、空白符以及其他字符出现的次数

#include <stdio.h>

int main(void)
{
 char s[1000];
 int i, numCount, spaceCount, vowelCount, consonantCount, otherCount;
 numCount = spaceCount = vowelCount = consonantCount = otherCount = 0;

 printf("Input the string: \n");
 scanf("%[^\n]", s);

 for (i = 0; s[i] != '\0'; i++)
 {
  if (s[i] == 'a' || s[i] == 'A' ||
      s[i] == 'e' || s[i] == 'E' ||
      s[i] == 'i' || s[i] == 'I' ||
      s[i] == 'o' || s[i] == 'O' ||
      s[i] == 'u' || s[i] == 'U')
  {
   vowelCount++;
  }
  else if ((s[i] >= 'a' && s[i] <= 'z') ||
           (s[i] >= 'A' && s[i] <= 'Z'))
  {
   consonantCount++;
  }
  else if (s[i] >= '0' && s[i] <= '9')
  {
   numCount++;
  }
  else if (s[i] == ' ')
  {
   spaceCount++;
  }
  else
  {
   otherCount++;
  }
 }

 printf("Vowel count is %d\n", vowelCount);
 printf("Consonant count is %d\n", consonantCount);
 printf("Number count is %d\n", numCount);
 printf("Space count is %d\n", spaceCount);
 printf("Other character count is %d\n", otherCount);

 return 0;
}
