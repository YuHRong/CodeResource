#include <stdio.h>

void chline(int ch, int j, int i);

int main(void)
{
  int ch;
  int j, i;

  // 提示用户输入字符
  printf("Enter a character: \n");

  while ((ch = getchar()) != '\n')
  {
    printf("Enter two integers: \n");
    if (scanf("%d %d", &j, &i) != 2)
      break;

    // 调用函数打印 j 行 i 列
    chline(ch, j, i);

    while (getchar() != '\n')
      continue;

    printf("Enter another character (a newline to quit): \n");
  }
  printf("Bye.\n");

  return 0;
}

void chline(int ch, int j, int i)
{
  int row, col;

  // 使用 for 循环打印行和列
  for (row = 1; row <= j; row++)
  {
    for (col = 1; col <= i; col++)
      putchar(ch);
    putchar('\n');
  }
}