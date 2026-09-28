// Write a program in C to calculate the length of a string using a pointer.

#include <stdio.h>

#define S 100

// 计算字符串长度的函数
int calculatorStrLength(char *);

int main(void)
{
 char str[S];
 int len;

 printf("\n\n Pointer : Calculate the length of the string :\n");
 printf("---------------------------------------------------\n");

 printf("Input the string : ");
 fgets(str, sizeof str, stdin);

 len = calculatorStrLength(str); // 获取输入字符串的长度

 printf(" The length of the given string %s is : %d \n", str, len - 1); // 显示字符串长度
}

// 计算字符串长度函数体
int calculatorStrLength(char *ch) // 获取指向字符串第一个字符的指针
{
 int count = 0;

 while (*ch != '\0')
 {         // 循环直到找到空字符“\0”
  count++; // 递增计数器
  ch++;    // 移动到下一个字符
 }

 return count;
}