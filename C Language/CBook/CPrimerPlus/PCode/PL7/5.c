#include <stdio.h>

int main(void)
{
 int ch, count1 = 0, count2 = 0;

 // 提示录入信息
 printf("Enter text to be analyzed (# to quit): \n");

 // 读取到 # 退出
 while ((ch = getchar()) != '#')
 {
  switch (ch)
  {
  case '!':
   // 用两个感叹号替换原来的感叹号
   putchar('!');
   putchar('!');
   count2++;
   break;
  case '.':
   // 用感叹号替换句号
   putchar('!');
   count1++;
   break;
  default:
   putchar(ch);
  }
 }

 // 打印替换次数
 printf("\n%d replacement(s) of . with !\n", count1);
 printf("%d replacement(s) of ! with !!\n", count2);
 printf("Total replace %d times\n", count1 + count2);
 printf("Done\n");

 return 0;
}