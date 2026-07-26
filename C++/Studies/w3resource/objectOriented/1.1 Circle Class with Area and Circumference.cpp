// Write a C++ program to implement a class called Circle that has private member variables for radius. Include member functions to calculate the circle's area and circumference.

#include <iostream>
#include <cmath> // 包含数学头文�?

const double PI = 3.14159; // �? PI 的值设置为常量

class Circle // 定义名为 Circle 的类
{
private:
 double radius;

public:
 // 构造函数
 Circle(double rad) : radius(rad) {}

 // ���� Circle ����ĺ���
 double calculateArea()
 {
  // ����Բ����Ĺ�ʽ
  return PI * pow(radius, 2);
 }

 // ����Բ�ܳ��ĺ���
 double calculateCircumference()
 {
  // ����Բ�ܳ��Ĺ�ʽ
  return 2 * PI * radius;
 }
};

int main()
{
 // ���� Circle ����
 double radius;
 std::cout << "Input the radius of the circle: ";
 std::cin >> radius; // 输入半径

 // 创建具有给定半径�? Circle 对象
 Circle circle(radius);

 // 计算并显示圆的面�?
 // 使用 circle 对象计算圆的面积
 double area = circle.calculateArea();

 // 输出计算后的面积
 std::cout << "Area : " << area << std::endl;

 // 计算并显示圆的周�?
 // 使用  circle 对象计算圆的周长
 double circumference = circle.calculateCircumference();

 // 输出计算后的周长
 std::cout << "Circumference: " << circumference << std::endl;

 return 0;
}