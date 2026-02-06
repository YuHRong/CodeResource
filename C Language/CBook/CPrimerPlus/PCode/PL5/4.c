#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#define FEET_INCHES 12    //1英尺等于12英寸
#define INCHES_CM 2.54    //1英寸等于2.54厘米

int main(void)
{
 float cm;

 printf("请输入你的升高（以厘米为单位），键入0退出:\n");
 scanf("%f", &cm);

 while (cm > 0)
 {
  float total_inches = cm / INCHES_CM;
  int feet = (int)(total_inches / FEET_INCHES);
  float inches = total_inches - feet * FEET_INCHES;

  printf("%.1f cm = %d feet, %.1f inches\n",
   cm, feet, inches);

  printf("输入0退出\n");
  scanf("%f", &cm);
 }
 printf("Bye.\n");
 return 0;
}