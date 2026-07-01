#include <stdio.h>

void chline(char ch, int j, int i);

int main(void)
{
 char ch;
 int j, i;    // i 打印次数，j 打印行数

 printf("Enter a character: \n");
 while ((ch = getchar()) != '\n')
 {
  printf("Enter two integers: \n");

  if (scanf("%d %d", &j, &i) != 2)
   break;

  // 调用函数打印 i 次，j 行
  chline(ch, i, j);

  while (getchar() != '\n')
   continue;

  printf("Enter another character (a newline to quit): \n");
 }
printf("Bye.\n");
 return 0;
}

void chline(char ch, int j, int i)
{
 int row, col;

 // 使用 for 循环打印次数行数。
 for (row = 1; row <= i; row++)
 {
  for (col = 1; col <= j; col++)
   putchar(ch);
  putchar('\n');
 }
}