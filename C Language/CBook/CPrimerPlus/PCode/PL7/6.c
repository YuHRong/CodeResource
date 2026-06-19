#include <stdio.h>

int main(void)
{
 int ch;         // 当前字符
 int prev = ' '; // 前一个字符
 int count = 0;  // ei 出现的次数

 printf("Please input chars (# to quit):\n");

 while ((ch = getchar()) != '#')
 {
  // 判断是否为ei
  if (prev == 'e' && ch == 'i')
  {
   count++;
  }
  else
  {
   // 记录前一个字符
   prev = ch;
  }
 }

 // 报告ei出现的次数
 printf("Total ei appear %d times in all chars.\n", count);
 printf("Done\n");

 return 0;
}