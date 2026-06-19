#include <stdio.h>

int main(void)
{
 int ch, count1, count2;

 // 提示录入信息
 printf("Enter text to be analyzed (# to quit)\n");

 // 读到 # 退出
 while ((ch = getchar()) != '#')
 {
  // 用两个感叹号替换原来的感叹号
  if (ch == '!')
  {
   putchar('!');
   putchar('!');
   count1++;
  }
  else if (ch == '.')
  {
   // 用感叹号替换句号
   putchar('!');
   count2++;
  }
  else
  {
   putchar(ch);
  }
 }

 // 报告替换次数
 printf("\n%d replacement(s) of . with !\n", count2);
 printf("%d replacement(s) of ! with !!\n", count1);
 printf("Total replace %d times\n", count1 + count2);
 printf("Don.\n");

 return 0;
}