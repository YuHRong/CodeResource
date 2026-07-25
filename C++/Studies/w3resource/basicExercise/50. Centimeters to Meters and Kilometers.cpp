// Write a C++ program to enter length in centimeters and convert it into meters and kilometers.

#include <iostream>

int main()
{
 float cm, m, km;

 std::cout << "Convert centimeter into meter and kilometer :\n";
 std::cout << "--------------------------------------------------\n";

 std::cout << "Input the distance in centimeter : ";
 std::cin >> cm;

 // 将输入的厘米除以 100 得到米
 m = cm / 100;
 // 将输入的厘米除以 100000 得到千米
 km = cm / 100000;

 std::cout << "The distance in meter is: " << m << std::endl;
 std::cout << "The distance in kilometer is: " << km << std::endl;

 return 0;
}