#include <iostream>

using namespace std;

class Shape // 基类
{
public:
 // 代参数构造函数
 // Shape(double l = 0, double w = 0, double h = 0) : length(l), width(w), height(h) {}
 // 纯虚函数，计算形状的面积，必须在派生类中写该函数
 virtual double area() = 0;

 // 虚函数，计算形状的体积
 virtual double volume()
 {
  cout << "该长方体体积" << endl;
  return 0;
 }

 // 析构函数
 virtual ~Shape() {}
};

// 派生类Rectangle
class Rectangle : public Shape
{
private:
 double length, width; // 举行特有属性，长和宽

public:
 // 构造函数,使用基类函数初始化 length 和 width
 Rectangle(double l, double w) : length(l), width(w) {}
 // Rectangle(double l = 0, double w = 0) : Shape(l, w) {}

 // 重写 area 函数计算面积
 double area() override
 {
  cout << "面积" << endl;
  return length * width;
 }
};

// 派生类 Triangle 三角形
class Triangle : public Shape
{
private:
 double length, width; // 三角形属性

public:
 // 构造函数，使用基类构造函数初始化 length  和 width
 Triangle(double l = 0, double w = 0) : length(l), width(w) {}

 // 重写 area 函数计算三角形面积
 double area() override
 {
  cout << "面积" << endl;
  return (length * width) / 2;
 }
};

// 派生类 Cuboid 表示长方体
class Cuboid : public Shape
{
private:
 double length, width, height; // 长宽高

public:
 // 构造函数，使用基类初始化 length, width 和 height
 Cuboid(double l = 0, double w = 0, double h = 0) : length(l), width(w), height(h) {}

 // 计算长方体表面积 函数
 double area() override
 {
  cout << "表面积" << endl;
  return 2 * ((length * width) + (length * height) + (width * height));
 }

 // 计算体积函数
 double volume() override
 {
  cout << "体积" << endl;
  return length * width * height;
 }
};

// main 函数
int main()
{
 Shape *s; // 基类指针

 Rectangle r(10, 5); // 举行对象
 Triangle t(10, 7);  // 三角形对象
 Cuboid c(10, 5, 4); // 长方体对象

 // 将基类指针指向矩形对象，并调用 area 函数
 s = &r;
 cout << "举行" << s->area() << endl;

 // 将基类指针指向三角形对象，并调用 area 函数
 s = &t;
 cout << "三角形" << s->area() << endl;

 // 将基类指针指向 Cuboid 对象，并调用 area 函数和 volume 函数
 s = &c;
 cout << "长方体 " << s->area() << endl;
 cout << "长方体" << s->volume() << endl;

 return 0;
}