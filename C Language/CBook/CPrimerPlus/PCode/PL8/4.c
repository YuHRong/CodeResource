/*
使用 charCount 存储字符数量，wordCount 存储单词数，使用 isWord 判断是否为单词。
使用 isalpha()() 函数判断是否是字母，
使用 isspace() 函数判断空格
*/

#include <stdio.h>
#include <ctype.h>
#include <stdbool.h>

int main(void)
{
  int ch;
  long charCount = 0, wordCount = 0;
  bool isWord = false;

  printf("Enter text: \n");
  while ((ch = getchar()) != EOF)
  {
    if (isalpha(ch))
      charCount++;

    if (!(isspace(ch) || ispunct(ch)) && !isWord)
    {
      isWord = true;
      wordCount++;
    }

    if ((isspace(ch) || ispunct(ch)) && isWord)
      isWord = false;
  }

  printf("\nThere are %ld words and %ld character.\n", wordCount, charCount);
  printf("The average number of letters in a word are %.2f", 1.0 * charCount / wordCount);

  return 0;
}