#include<stdio.h>

int main(void) {
 int i, x, y, z;

 // 便利100 到 999 的数字
 for (i = 100; i < 1000; i++) {
  // 计算各位数字
  x = i % 10;      // 各位
  y = (i / 10) % 10;     // 十位
  z = (i / 100) % 10;     // 百位

  // 计算立方和
  int sum = x * x * x + y * y * y + z * z * z;

  // 判断是否为水仙花数
  if (i == sum) {
   printf("%d\n", i);
  }
 }

 return 0;
}