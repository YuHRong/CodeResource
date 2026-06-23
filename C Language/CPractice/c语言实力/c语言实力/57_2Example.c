// 不使用 strlen() 函数计算字符串长度

#include <stdio.h>

int main(void)
{
 char s[1000];
 int i;

 printf("Input the string: \n");
 scanf("%s", s);

 for (i = 0; s[i] != '\0'; i++)
  ;
 printf("String length is %d\n", i);

 return 0;
}