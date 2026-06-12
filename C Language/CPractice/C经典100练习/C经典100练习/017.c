// 输入一行字符，分别统计出其中英文字母、空格、数字和其它字符的个数。
#include<stdio.h>

int main(void)
{
 char c;
 int letter = 0, spaces = 0, digict = 0, other = 0;

 printf("请输入字符： ");
 while ((c = getchar()) != '\n')
 {
  if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
  {
   letter++;
  }
  else if (c >= '0' && c <= '9')
  {
   digict++;
  }
  else if (c == ' ')
  {
   spaces++;
  }
  else
  {
   other++;
  }
 }
 printf("字母 = %d, 数字 =%d, 空格 = %d, 其他 = %d\n", letter, digict, spaces, other);

 return 0;
}