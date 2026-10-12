// Write a C++ program to print the area of a hexagon.

#include <iostream>
#include <cmath>

// 函数声明
void printInfo();
double hexagonSide();
double calculatorHexagonArea(double side);
void printAreaInfo(double area);

int main()
{
 // 调用函数
 printInfo();
 double side{hexagonSide()};               // 返回 hexagonSide 并将值复给 side
 double area{calculatorHexagonArea(side)}; // 传递 side 给 calculatorHexagonArea 函数进行计算
 printAreaInfo(area);                      // 调用打印面积函数

 return 0;
}

// 函数体
void printInfo()
{ // 打印提示信息
 std::cout << "Print the area of a hexagon: " << '\n';
 std::cout << "---------------------------------" << '\n';
 std::cout << '\n';
}

double hexagonSide()
{ // 获取边长
 std::cout << "Input the side of the hexagon: ";
 double side{};
 std::cin >> side;
 std::cout << '\n';
 return side;
}

double calculatorHexagonArea(double side)
{ // 面积计算函数
 return (side * side * sqrt(3)) / 4 * 6;
}

void printAreaInfo(double area)
{ // 打印面积函数
 std::cout << "The area of the hexagon is: " << area;
 std::cout << '\n';
}