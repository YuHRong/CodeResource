/* wheat.c -- 指数增长 */
#include<stdio.h>
#define SQUARES 64        //  棋盘中的方格数
int main(void) {
 const double CROP = 2e16;  // 世界小麦年产粒数
  double current, total;
 int count = 1;

 printf("squre     grains       total     ");
 printf("fraction of \n");
 printf("           added        grains    ");
 printf("world total\n");
 total = current = 1.0;        // 从一颗小麦开始
 printf("%4d %13.2e %12.2e %12.2e\n", count, current,
  total, total / CROP);
 while (count < SQUARES) {
  count = count + 1;
  current = 2.0 * current;    // 下一个方格小麦翻倍
  total = total + current;    /* 更新总数 */
  printf("%4d %13.2e %12.2e %12.2e\n", count, current,
   total, total / CROP);
 }
 printf("That's all.\n");

 return 0;
}