// file_eof.c --打开一个文件并显示该文件
#include<stdio.h>
#include<stdlib.h>          // 为了使用exit()
#include <errno.h> // 为了使用errno
int main()
{
 int ch;
 FILE* fp = NULL;
 char fname[50];     // 储存文件名

 printf("Enter the name of the file: ");
 scanf_s("%s", fname, (unsigned)_countof(fname));

// fp = fopen_s(fname, "r");    // 打开该读取文件
 errno_t err = fopen_s(&fp, fname, "r");
 if (fp == NULL) // 如果失败
 {
  printf("Failed to open file. Bye\n");
  exit(1);     // 退出文件
 }

 // getc(fp) 从打开的文件中获取一个字符
 while ((ch = getc(fp)) != EOF)
  putchar(ch);
 fclose(fp);      // 关闭文件

 return 0;
}