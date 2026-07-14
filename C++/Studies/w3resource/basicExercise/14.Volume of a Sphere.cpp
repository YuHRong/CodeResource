// Write a C++ program that calculates the volume of a sphere.

#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
 cout << "Calculate the volume of a sphere :" << endl;
 cout << "---------------------------------------" << endl;

 // 申明 pi 的变量为 3.1415926
 double pi = 3.1415926;
 // 申明半径变量
 double radius;
 double v = 0; // 初始化体积变量为 0

 cout << "Input the radius of a sphere : ";
 cin >> radius;

 v = (4 * pi * radius * radius * radius) / 3;

 cout << fixed << setprecision(2);
 cout << " The volume of a sphere is : " << v << endl;

 cout << endl;

 return 0;
}