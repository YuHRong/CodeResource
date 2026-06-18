// 将一个数组复制给另外一个数组：
#include <stdio.h>

int main(void)
{
 int oringinalArray[10] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
 int copyArray[10];
 int loop;

 for (loop = 0; loop < 10; loop++)
 {
  copyArray[10] = oringinalArray[loop];
 }
 printf("元素数组 -> 拷贝后的数组 \n");

 for (loop = 0; loop < 10; loop++)
 {
  printf("   %2d        %2d\n", oringinalArray[loop], copyArray[10]);
 }

 return 0;
}