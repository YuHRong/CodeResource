// 不使用 strcpy() 函数 将一个字符串复制到另一个字符串中

#include<stdio.h>

int main(void)
{
 char str1[1000], str2[1000];
 int i;

 printf("Input first string: \n");
 scanf("%[^\n]", str1);

 for(i = 0; str1[i] != '\0'; i++){
  str2[i] = str1[i];
 }
 str2[i] = '\0';

 printf("Second string is %s\n", str2);

 return 0;
}