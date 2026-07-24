// Write a C++ program to get the volume of a sphere with radius 6.

#include <iostream>
#include <cmath>

#define PI 3.1415926

int main()
{
 float radius, volume = 0.0;

 std::cout << "Calculate the volume of a sphere :\n";
 std::cout << "---------------------------------------\n";

 std::cout << "Input the radius of a sphere : " << std::endl;
 std::cin >> radius;

 volume = (4.0 / 3.0) * PI * std::pow(radius, 3);

 std::cout << "The volume of a sphere is : " << volume << std::endl;

 return 0;
}