// 字符串复制
// 使用 strcpy() 将一个变量的字符串复制到另外一个变量中。

#include <stdio.h>
#include <string.h>

int main(void)
{
 char str1[1000], str2[1000];

 memset(str2, '\0', sizeof(str2));
 strcpy(str1, "This is a string\n");
 strcpy(str2, str1);

 printf("最终的目标字符串： %s\n", str2);

 return 0;
}