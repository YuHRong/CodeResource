// Write a C++ program to enter two angles of a triangle and find the third angle.

#include <iostream>

const double ANGLE_TOTAL = 180;

// using namespace std;
int main()
{
 double angle1, angle2, angle3;

 std::cout << "Find the third angle of a triangle :\n";
 std::cout << "-----------------------------------------\n";

 std::cout << "Input the 1st angle of the triangle : ";
 std::cin >> angle1;

 std::cout << "Input the 2nd angle of the triangle : ";
 std::cin >> angle2;

 if (std::cin.fail())
 {
  std::cerr << "\n错误，请输入有效数字\n";
  return 1;
 }

 if (angle1 <= 0 || angle2 <= 0)
 {
  std::cerr << "错误，三角形的角不能小于等于0\n";
  return 1;
 }

 if ((angle1 + angle2) >= ANGLE_TOTAL)
 {
  std::cerr << "三角形的两个角之和不能大于等于 180\n";
  return 1;
 }

 angle3 = ANGLE_TOTAL - (angle1 + angle2);
 
 std::cout << "The 3rd of the triangle is : " << angle3 << std::endl;

 return 0;
}