// Write a C++ program to create a class called Rectangle that has private member variables for length and width. Implement member functions to calculate the rectangle's area and perimeter.

#include <iostream>

class Rectangle
{
private:
 double length;
 double width;

public:
 // 构造函数
 Rectangle(double len, double wid) : length(len), width(wid) {}

 // 计算面积函数
 double calculateArea()
 {
  // 计算举行面积公式
  return length * width;
 }

 // 计算举行周长函数
 double calculatePerimeter()
 {
  // 计算周长公式
  return (length + width) * 2;
 }
};

int main()
{
 double length, width;

 // 获取rectangle 的长度和宽度
 std::cout << "Please enter the rectangles length: ";
 std::cin >> length;
 std::cout << "Please enter the rectangles width: ";
 std::cin >> width;

 // 创建具有周长和宽度的 rectangle 对象
 Rectangle rectangle(length, width);

 // 使用 rectangle 对象计算举行的面积
 double area = rectangle.calculateArea();
 // 打印计算后的面积
 std::cout << "Area : " << area << std::endl;

 // 计算周长
 double perimeter = rectangle.calculatePerimeter();
 // 显示计算后的周长
 std::cout << "Perimeter : " << perimeter << std::endl;

 return 0;
}