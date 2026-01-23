#include<stdio.h>
#include<string.h>
int main(void)
{
 char name[30];
 char surname[30];

 printf("请输入姓:");
 scanf_s("%s", surname, (unsigned)sizeof(name));
 printf("请输入名:");
 scanf_s("%s", name, (unsigned)sizeof(name));
 printf("你的姓名是： %s,%s\n", name, surname);

 return 0;

}