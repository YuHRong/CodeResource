#include <iostream>

class Shape
{
public:
 /* data */
 virtual double area() = 0; // 纯虚函数
 virtual void draw() = 0;   // 另一个纯虚函数
};

class Circle : public Shape
{
private:
 double radius;

public:
 Circle(double r) : radius(r) {}
 double area() override
 {
  return 3.14159 * radius * radius; // 计算面积
 }

 void draw() override
 {
  std::cout << "Drawing Circle" << std::endl; // 实现绘制
 }
};

class Square : public Shape
{
private:
 double side;

public:
 Square(double s) : side(s) {}

 double area() override
 {
  return side * side; // 实现面积计算
 }

 void draw() override
 {
  std::cout << "Drawing Square" << std::endl; // 实现绘制
 }
};
