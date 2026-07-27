#include <iostream>

class Rectangle
{
private:
 /* data */
 int width, height; // 数据成员，属性

public:
 // 构造函数
 Rectangle(int w, int h) : width(w), height(h) {}

 // 成员函数、方法
 int area()
 {
  return width * height; // 计算面积
 }
};

int main()
{
 Rectangle rect(10, 5); // 创建对象

 std::cout << "面积： " << rect.area() << std::endl; // 调用成员函数

 return 0;
}