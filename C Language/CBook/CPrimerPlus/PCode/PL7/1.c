#include<stdio.h>

int main(void){
 int ch;
 int space_count = 0;
 int newlines_count = 0;
 int other = 0;

 printf("请输入字符 (# 退出):");
 while ((ch = getchar()) != '#') {
  if (ch == ' ')
   // 统计空格符
   space_count++;
  else if (ch == '\n')
   // 统计换行符
   newlines_count++;
  else
   // 统计其他字符
   other++;
 }

 printf("空格数量 = %d, 换行符 = %d, 其他字符 = %d\n",
  space_count, newlines_count, other);

 return 0;
}