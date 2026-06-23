// 使用 strlen() 函数计算字符串的长度

#include <stdio.h>
#include <string.h>

int main(void)
{
 char s[1000];
 int len;

 printf("Input the string: \n");
 scanf("%s", s);
 len = strlen(s);

 printf("String length is %d\n", len);
printf("%p\n", len);

return 0;
}