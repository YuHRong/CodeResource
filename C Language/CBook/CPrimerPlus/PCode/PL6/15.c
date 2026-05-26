#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<string.h>

#define SIZE 255

int main(void)
{
 char ar[SIZE];
 int i = 0, len;

 // 提示用户输入一行字符
 printf("Enter the char in a line:\n");
 do
 {
  // 循环读取用户输入的字符，保存到字符数组中，直到输入换行符
  scanf("%c", &ar[i]);
 } while (ar[i++] != '\n');

 // 打印倒序的内容
 printf("The reverse char of the data:\n");
 // 删除数组中的最后一个字符
 len = strlen(ar) - 2;
 for (i = len; i >= 0; i--)
 {
  printf("%c", ar[i]);
 }

 return 0;
}