// 1.你刚被MacroMuscle有限公司聘用。该公司准备进入欧洲市场,需要一个把英寸单位转换为厘米单位(1英寸=2.54厘米)的程序。
// 该程序要提示用户输入英寸值。你的任务是定义程序目标和设计程序(编程过程的第1步和第2步)。 
//定义英寸和厘米的变量为float。
// 提示用户输入
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 float inches;
 float cm = 0.0;

 printf("Enter inches, Please:\n");
 scanf("%f", &inches);
 printf("%f", inches);

 return 0;
}