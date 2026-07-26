// Write a C++ program to implement a Circle class that calculates area and circumference, and then overload the << operator to print its details.

#include <iostream>
#include <cmath>

const double PI = 3.1415926;

class Circle
{
private:
 double radius;

public:
 Circle(double r) : radius(r)
 {
  if (r <= 0)
  {
   std::cerr << "原型创建失败\n";
   return;
  }
 }

 void setRadius(double r)
 {
  radius = r;
 }

 // getter 函数
 double getRadius() const
 {
  return radius;
 }

 // 计算面积函数
 double calculatorArea() const
 {
  return PI * pow(radius, 2);
 }

 double calculatorPerimeter() const
 {
  return 2 * PI * radius;
 }

 // 友元声明：允许全局的 operator<< 函数访问 Circle 的私有成员
 // 有元重在例子
 friend std::ostream &operator<(std::ostream &os, const Circle &circle);
};

// 重载 << 运算符的实现
std::ostream &operator<<(std::ostream &os, const Circle &circle)
{
 os << "圆形信息：" << std::endl;
 os << "  半径: " << circle.getRadius() << std::endl;
 os << "  面积: " << circle.calculatorArea() << std::endl;
 os << "  周长: " << circle.calculatorPerimeter(); // 注意这里没有 std::endl，让调用者决定是否换行
 return os;                                        // 必须返回 ostream 引用，以便链式调用
}

int main()
{
 Circle c1(-2);
 // std::cout << "Circle 1 的信息" << std::endl;
 std::cout << c1 << std::endl;

 return 0;
}