// Write a C++ program that calculates the volume of a side.

#include <iostream>
#include <cmath>

using namespace std;

int main()
{
 double side;       // 申明一个存储立方体边长的变量
 double volume = 0; // 申明存储体积的变量

 cout << "Calculate the volume of a cube : " << endl;
 cout << "---------------------------------------" << endl;

 cout << "Input the side of a cube : " << endl;
 cin >> side;

 volume = side * side * side;

 cout << "The volume of a cube is : " << volume << endl;

 cout << endl;

 return 0;
}