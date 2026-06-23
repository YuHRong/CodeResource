// 删除字符串中的除字母外的字符。

#include <stdio.h>

int main()
{
 char line[150];
 int i, j;

 printf("Input a string: ");
 fgets(line, (sizeof line / sizeof line[0]), stdin);

 for (i = 0; line[i] != '\0'; i++)
 {
  while (!((line[i] >= 'a' && line[i] <= 'z') || (line[i] >= 'A' && line[i] <= 'Z') || line[i] == '\0'))
  {
   for (j = i; line[j] != '\0'; j++)
   {
    line[j] = line[j + 1];
   }
   line[j] = '\0 ';
  }
 }
 printf("output:\n");

 puts(line);

 return 0;
}