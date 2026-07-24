// Write a C++ program to calculate the volume of a cone.

#include <iostream>
#include <cmath>

int main()
{
 float radius, height, volume = 0.0;
 const float pi = 3.1415926;

 std::cout << "Input Cone's radius: ";
 std::cin >> radius;
 std::cout << "Input Cone's height: ";
 std::cin >> height;

 volume = (1.0 / 3.0) * pi * std::pow(radius, 2) * height;

 std::cout << "The volume of the cone is: " << volume << std::endl;

 return 0;
}