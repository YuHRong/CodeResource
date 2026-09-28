// Define a structure named Circle to represent a circle with a radius. Write a C program to calculate the area and perimeter of two circles and display the results.

#include <stdio.h>
#include <math.h>

#define PI 3.1415926

// 申明名为 Circle 的结构体
struct Circle
{
 double radius;
};

// 计算面积的函数
double calculatorArea(struct Circle r)
{
 return PI * pow(r.radius, 2);
}

// 计算周长函数
double calculatorPerimeter(struct Circle r)
{
 return 2 * PI * r.radius;
}

int main(void)
{
 // 申明结构变量存储两个圆的信息
 struct Circle c1, c2;

 // 输入第一个圆信息
 printf("Input details for Circle 1:\n");
 printf("Radius: ");
 scanf("%lf", &c1.radius);
 // 输入第二个圆信息
 printf("Input details for Circle 2:\n");
 printf("Radius: ");
 scanf("%lf", &c2.radius);

 // 计算并显示圆的面积和周长
 printf("\nCircle1\n");
 printf("Area = %.2lf\n", calculatorArea(c1));
 printf("perimeter = %.2lf\n", calculatorPerimeter(c1));

 printf("\nCircle2\n");
 printf("Area = %.2lf\n", calculatorArea(c2));
 printf("perimeter = %.2lf\n", calculatorPerimeter(c2));

 return 0;
}