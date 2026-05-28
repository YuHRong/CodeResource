// 获取输入半径，计算球体体积
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

#define PI 3.1415926f

int main(void)
{
 float radius, volume;

 printf("请输入球体半径： ");
 scanf("%f", &radius);

 volume = (4.0 / 3.0) * PI * (radius * radius * radius);
 printf("球体体积为： %.2f\n", volume);

 return 0;
}