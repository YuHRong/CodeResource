// Write a C program that calculates the volume of a sphere.

#include <stdio.h>

// PI 的前50位
#define PI 3.14159265358979323846264338327950288419716939937510

int main()
{
 double radius;      // 申明保存圆柱半径的变量
 double volume = 0;  // 申明保存体积的变量
 char inputLine[50]; // 一行输入

 printf("Input the radius of the sphere : ");
 // 读取输入并存储在 inputLine 中
 fgets(inputLine, sizeof(inputLine), stdin);
 // 将 inputLine 中获取的值转为 double 数据类型存储在 radius 中
 sscanf(inputLine, "%lf", &radius);

 volume = (4.0 / 3.0) * PI * (radius * radius * radius);

 printf("The volume of sphere is % lf.\n", volume);

 return 0;
}