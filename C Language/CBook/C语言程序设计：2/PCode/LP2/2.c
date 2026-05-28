// 计算球体半径为 10 的球体体积
#include<stdio.h>

#define FRAC (4.0f / 3.0f)
#define PI 3.1415926f

int main(void)
{
 float radius = 10.0f, volume;
 volume = (FRAC * PI) * (radius * radius * radius);

 printf("球体体积为： %.2f\n", volume);

 return 0;
}