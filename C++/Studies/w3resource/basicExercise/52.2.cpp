// Write a C++ program that computes the third angle, then categorizes the triangle as acute, right, or obtuse based on all three angles.
// Write a C++ program to calculate the missing angle of a triangle using user-defined functions and incorporate error handling for invalid angles.
// Write a C++ program that reads two angles and calculates the third angle, then prints a warning if the triangle is nearly degenerate.

#include <iostream>
#include <cmath>

const double ANGLE_TOTAL = 180.0;
const double EPSILON = 0.0001;

// 申明函数
double angle3_result(double an1, double an2);

int main()
{
 double angle1, angle2, angle3;

 std::cout << "输入三角形的第一个角： ";
 std::cin >> angle1;

 // 检查第一个角是否输入有效数字
 if (std::cin.fail())
 {
  std::cerr << "输入错误，请输入数字\n";
  return 1;
 }

 std::cout << "输入三角形的第二个角： ";
 std::cin >> angle2;

 // 检查第二个角是否输入有效数字
 if (std::cin.fail())
 {
  std::cerr << "输入错误，请输入数字\n";
  return 1;
 }

 // 检查输入是否小于等于 0
 if (angle1 <= 0 || angle2 <= 0)
 {
  std::cerr << "三角形的角不能小于或等于 0，请重新输入\n";
  return 1;
 }

 // 检查两个角之和是否大于或等于 180
 if ((angle1 + angle2) >= ANGLE_TOTAL)
 {
  std::cerr << "错误：三角形的两个角的和不能大于或等于 180\n";
  return 1;
 }

 // 计算第三个角
 angle3 = angle3_result(angle1, angle2);

 // 判断是否为退化三角形
 if (angle1 <= EPSILON || angle2 <= EPSILON || angle3 <= EPSILON)
 {
  std::cout << "警告！这是一个几乎退化的三角形\n";
 }

 // 打印三个角
 std::cout << "三角形的第一个角 = " << angle1 << ", 第二个角 = " << angle2 << ", 第三个角 = " << angle3 << "。" << std::endl;

 // 三角形分类判断
 if (abs(angle1 - 90.0) < EPSILON || abs(angle2 - 90.0) < EPSILON || abs(angle3 - 90.0) < EPSILON)
 {
  std::cout << "这是一个直角三角形\n";
 }
 else if (angle1 > (90 + EPSILON) || angle2 > (90 + EPSILON) || angle3 > (90 + EPSILON))
 {
  std::cout << "这是一个钝角三角形\n";
 }
 else
 {
  std::cout << "这是一个锐角三角形\n";
 }

 return 0;
}

// 函数定义
double angle3_result(double ang1, double ang2)
{
 return ANGLE_TOTAL - (ang1 + ang2);
}