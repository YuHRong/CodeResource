// Write a C++ program to calculate the volume of a cylinder.

#include <iostream>

int main()
{
 const float pi = 3.1415926;
 float radius, height, volume = 0.0;

 std::cout << "Calculate the volume of a cylinder :\n";
 std::cout << "-----------------------------------------\n";

 std::cout << "Input the radius of the cylinder : ";
 std::cin >> radius;
 std::cout << "Input the height of the cylinder : ";
 std::cin >> height;

 volume = pi * height * radius * radius;

 std::cout << "The volume of a cylinder is : " << volume << std::endl;

 return 0;
}