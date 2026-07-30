//输入三个整数 x、y、z，请把这三个数由小到大输出。
//先将x分别以y,z相比，若x大于y择y排在x前面，若x大于z择x排在最后。

#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int x, y, z, w;

 printf("请输入三个整数:\n");
 scanf("%d %d %d", &x, &y, &z);
// printf("你输入的整数为: %d, %d, %d\n", x, y, z);

 if (x > y)
 {
  w = x;
  x = y;
  y = w;
 }
 if (x > z)
 {
  w = z;
  z = x;
  x = w;
 }
 if (y > z)
 {
  w = z;
  z = y;
  y = w;
 }
 printf("三个数从小到大排序为: %d, %d, %d\n", x, y, z);
 return 0;
}