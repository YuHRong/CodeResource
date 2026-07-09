// 写一个C语言程序来计算给定半径的圆的周长和面积。


#include <stdio.h>

int main(void)
{
 float radius;            // 用于保存原半径的变量
 float area, perimeter; // 用于存储原周长和面积的变量

 printf("Please enter the radius of the Circle\n");
scanf("%f", &radius);

 // 计算原的周长
 perimeter = 2 * 3.14 * radius;
 printf("Perimeter of the Circle = %f inches\n", perimeter);

 // 计算原的面积
 area = 3.14 * radius * radius;
 printf("Area of the Circle = %f square inches\n", area);

 return 0;
}