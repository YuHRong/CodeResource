#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 float speed;    // 下载速度，以兆字节每秒为单位。
 float size;    // 文件大小。

 printf("请输入文件大小，以兆为单位：\n");
 scanf("%f", &size);

 printf("请输入下载速度:\n");
 scanf("%f", &speed);

printf("At %.2f megabits per second, a file of %.2f megabytes\ndownloads in %.2f seconds.\n", speed, size, size / (speed / 8));

 return 0;
}