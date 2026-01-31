#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<string.h>

int main(void)
{
 char name[40];

 printf("请输入你的名字:\n");
 scanf("%s", name, (unsigned)sizeof(name));

 //打印"名字":
 printf("\n\"%s\"\n", name);

 //在右端打印"名字":
 printf("\"%20s\"\n", name);

 //在左端打印"名字":
 printf("\"%-20s\"\n", name);

 //在比字符宽3中打印"名字":
 printf("%*s\n", (int)strlen(name) + 3, name);

 return 0;
}