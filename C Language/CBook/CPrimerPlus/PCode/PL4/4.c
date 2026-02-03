#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 float highCm;
 float highInc;
 char name[20];

 printf("请输入你的升高，以英寸为单位:\n");
 scanf("%f", &highInc);

 printf("请输入你的身高，厘米为单位:\n");
 scanf("%f", &highCm);

 printf("请输入你的姓名:\n");
 scanf("%s", name);

 printf("%s 你的升高是: %.3f 英尺，你的升高是 %.3f 米\n", name, highInc / 12.0, highCm / 100.0);

  return 0;
}