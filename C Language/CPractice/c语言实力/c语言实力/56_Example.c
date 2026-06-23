// 连接字符串
// 使用 strcat() 连接两个字符串。

#include <stdio.h>

int main()
{
 char s1[100], s2[100], i, j;

 printf("Input the first string: \n");
 scanf("%s", s1);
 printf("Input the second string: \n");
 scanf("%s", s2);

 // 计算字符串 s1 的长度
 for (i = 0; s1[i] != '\0'; i++)
  ;
 for (j = 0; s2[j] != '\0'; j++, i++)
 {
  s1[i] = s2[j];
 }

 s1[i] = '\0 ';

 printf("%s\n", s1);

 return 0;
}