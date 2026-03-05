#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main() {
 char input_char;
 int num_rows;

 // 提示用户输入大写字母
 printf("请输入一个大写字母: ");
 scanf(" %c", &input_char);

 // 验证用户输入是否为大写字母
 //if (input_char < 'A' || input_char > 'Z') {
  //printf("输入无效。请输入一个大写字母。\n");
  //return 1; // 表示程序出错退出
 //}

 // 计算行数，根据输入字母决定
 num_rows = input_char - 'A' + 1;

 // 外层循环处理行
 for (int i = 1; i <= num_rows; i++) {
  // 内层循环1：打印空格
  // 每行需要打印的空格数是 num_rows - i
  for (int j = 0; j < num_rows - i; j++) {
   printf(" ");
  }

  // 内层循环2：以升序打印字母
  // 从 'A' 开始，打印到当前行对应的字母
  for (int k = 0; k < i; k++) {
   printf("%c", 'A' + k);
  }

  // 内层循环3：以降序打印字母
  // 从当前行倒数第二个字母开始，打印到 'A'
  for (int l = i - 2; l >= 0; l--) {
   printf("%c", 'A' + l);
  }

  // 打印完一行后换行
  printf("\n");
 }

 return 0;
}