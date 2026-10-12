// Write a C++ program to calculate the area of a hexagon and then compute the perimeter, given the side length.

#include <iostream>
#include <cmath>
#include <vector>

// 函数声明
void printInfo();            // 打印提示信息
double setArea(double side); // 获取面积
double setArea(const std::vector<double> &side);
double setPerimeter(double side); // 获取周长
double setPerimeter(const std::vector<double> &side);
int printOption();                                                // 选择是否为正六边形
double getRegularHexagonSide();                                   // 获取正六边形边长
std::vector<double> getIrregularHexagonSide();                    // 获取不规则六边形边长保存在 vector 中
double calculatorHexagonArea(double side);                        // 计算正六边形面积
double calculatorHexagonArea(const std::vector<double> &side);    // 计算不规则六边形面积
double calculatorHexagonPerimeter(double si);                     // 计算正六边形周长
double calculatorHexagonPerimeter(const std::vector<double> &si); // 计算不规则六边形周长
void printHexagonInfo(double area, double perimeter);             // 打印面积和周长

int main()
{
 double regularHexagonSide{};
 std::vector<double> irregularHexagonSide{};
 double area{}, perimeter{};

 // 调用函数
 printInfo();
 int count{printOption()};

 if (count == 1)
 {
  regularHexagonSide = getRegularHexagonSide();
  area = setArea(regularHexagonSide);
  perimeter = setPerimeter(regularHexagonSide);
 }
 else
 {
  irregularHexagonSide = getIrregularHexagonSide();
  area = setArea(irregularHexagonSide);
  perimeter = setPerimeter(irregularHexagonSide);
 }

 printHexagonInfo(area, perimeter); // 调用打印面积函数

 return 0;
}

// 函数体
// 打印提示信息
void printInfo()
{
 std::cout << "Print the area and perimeter of a hexagon: " << '\n';
 std::cout << "---------------------------------" << '\n';
 std::cout << '\n';
}

// 获取计算面积函数
double setArea(double side)
{
 double area{calculatorHexagonArea(side)};
 return area;
}
// 函数重在获取不规则六边形面积计算函数
double setArea(const std::vector<double> &side)
{
 double area{calculatorHexagonArea(side)};
 return area;
}

// 获取周长函数
double setPerimeter(double side)
{
 double perimeter{calculatorHexagonPerimeter(side)};
 return perimeter;
}
// 函数重在获取周长
double setPerimeter(const std::vector<double> &side)
{
 double perimeter{calculatorHexagonPerimeter(side)};
 return perimeter;
}

// 打印询问信息，是否为正六边形或不规则六边形
int printOption()
{
 std::cout << "Please choose: 1. Regular hexagon, 2. Irregular hexagon.";
 int choice{};
 while (true)
 {
  std::cin >> choice;
  if (choice >= 1 && choice <= 2)
   break;
  else
   std::cout << "please enter again";
 }
 std::cout << '\n';

 return choice;
}

// 获取正六边形的边长
double getRegularHexagonSide()
{
 std::cout << "Input the side of the hexagon: ";
 double side{};
 while (true)
 {
  std::cin >> side;
  if (side > 0)
   break;
  else
   std::cout << "Please enter enter again: ";
  std::cout << '\n';
 }
 return side;
}
// 获取不规则六边形的边长
std::vector<double> getIrregularHexagonSide()
{
 std::vector<double> side{};
 std::cout << "Please input the lengths of the 6 sides of the hexagon, one by one:" << '\n';
 double inputSide{};
 for (int i = 0; i < 6; i++)
 {
  std::cout << "side - " << i + 1 << " : ";
  while (true)
  {
   std::cin >> inputSide;
   if (inputSide > 0)
    break;
   else
    std::cout << "Please enter again";
  }
  side.push_back(inputSide);
 }
 std::cout << '\n';
 return side;
}

// 面积计算函数
double calculatorHexagonArea(double side)
{
 return (side * side * sqrt(3)) / 4 * 6;
}
// 函数重在不规则六边形面积计算函数
double calculatorHexagonArea(const std::vector<double> &side)
{
 std::cout << "Warning: Cannot accurately calculate the area of an irregular hexagon with only side lengths.\n";
 return 0.0;
}

// 正六边形周长计算函数
double calculatorHexagonPerimeter(double si)
{
 return si * 6;
}
// 函数重在不规则六边形周长计算函数
double calculatorHexagonPerimeter(const std::vector<double> &side)
{
 double perimeter{};
 for (double si : side)
 {
  perimeter += si;
 }
 return perimeter;
}

// 打印面积函数
void printHexagonInfo(double area, double perimeter)
{
 std::cout << "The area of the hexagon is: " << area;
 std::cout << '\n';
 std::cout << "perimeter is : " << perimeter;
 std::cout << '\n';
}
