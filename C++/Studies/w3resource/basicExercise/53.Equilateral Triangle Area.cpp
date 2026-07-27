#include <iostream>
#include <cmath>

int main()
{
 double side, area = 0.0;

 std::cout << "Calculate the area of the Equilateral Triangle :\n";
 std::cout << "----------------------------------------------------\n";

 std::cout << "Input the value of the side of the equilateral triangle: ";
 std::cin >> side;

 area = (side * side * sqrt(3)) / 4;

 std::cout << "The area of equilateral triangle is: " << area << std::endl;

 return 0;
}