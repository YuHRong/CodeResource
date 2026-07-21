// Write a C++ program to implement a class called Circle that has private member variables for radius. Include member functions to calculate the circle's area and circumference.

#include <iostream>
#include <cmath> // 包含数学头文件

const double PI = 3.14159; // 将 PI 的值设置为常量

class Circle // 定义名为 Circle 的类
{
private:
 double radius;

public:
 // 构造函数，用于初始化具有原半径的对象
 Circle(double rad) : radius(rad) {}

 // 计算 Circle 面积的函数
 double calculateArea()
 {
  // 计算圆面积的公式
  return PI * pow(radius, 2);
 }

 // 计算圆周长的函数
 double calculateCircumference()
 {
  // 计算圆周长的公式
  return 2 * PI * radius;
 }
};

int main()
{
 // 创建 Circle 对象
 double radius;
 std::cout << "Input the radius of the circle: ";
 std::cin >> radius; // 输入半径

 // 创建具有给定半径的 Circle 对象
 Circle circle(radius);

 // 计算并显示圆的面积
 // 使用 circle 对象计算圆的面积
 double area = circle.calculateArea();

 // 输出计算后的面积
 std::cout << "Area : " << area << std::endl;

 // 计算并显示圆的周长
 // 使用  circle 对象计算圆的周长
 double circumference = circle.calculateCircumference();

 // 输出计算后的周长
 std::cout << "Circumference: " << circumference << std::endl;

 return 0;
}