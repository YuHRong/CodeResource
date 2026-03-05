#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<string.h>
#define LEN 40

int main(void)
{
 char ch[LEN];
 int i, length;

 // 提示输入单词
 printf("请输入一个单词:");
 scanf("%s", &ch,(unsigned)sizeof(ch));

// 获取单词字符
 length = strlen(ch) - 1;

  // 检查输入单词
 printf("您输入的单词是: %s\n", ch);

 // 倒叙打印单词
 for (i = length; i >= 0; i--)
 {
  printf("%c", ch[i]);
}
 printf("\n");

 return 0;
}