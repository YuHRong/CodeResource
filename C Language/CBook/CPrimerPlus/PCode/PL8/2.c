#include <stdio.h>

int main(void)
{
 int ch, count = 0;

 while ((ch = getchar()) != EOF)
 {
  if (count++ == 10)
  {
   printf("\n");
   count = 1;
  }

  // 大于空格字符显示字符和相应的ASCII码
  if (ch == '\040')
  {
   printf("%2c-%3d ", ch, ch);
  }
  // 处理制表符
  else if (ch == '\t')
  {
   printf("\\t-%3d", ch);
   printf(" ");
  }
  // 处理换行符
  else if (ch == '\n')
  {
   printf("\\n-%3d\n", ch);
   count = 0;
  }
  // 处理其他的非打印字符
  else
  {
   printf("^%c-%3d", ch, (ch + 64));
  }
 }

 return 0;
}