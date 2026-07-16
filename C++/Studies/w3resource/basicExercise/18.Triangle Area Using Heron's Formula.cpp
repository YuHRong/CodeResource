// Write a C++ program to find the area of any triangle using Heron's formula.

#include <iostream>
#include <cmath>

using namespace std;

int main()
{
 double len1, len2, len3, s = 0, area = 0;

 cout << "Find the area of any triangle using Heron's Formula :" << endl;
 cout << "----------------------------------------------------------\n";

 cout << "Input the length of 1st side of the triangle : ";
 cin >> len1;

 cout << "Input the length of 2nd side of the triangle : ";
 cin >> len2;

 cout << "Input the length of 3rd side of the triangle : ";
 cin >> len3;

 // 边界检查
 // if (len1 + len2 > len3 && len1 + len3 > len2 && len2 + len3 > len1)
 // {
  s = (len1 + len2 + len3) / 2;
  area = sqrt(s * (s - len1) * (s - len2) * (s - len3));
  cout << "The area of the triangle is : " << area << endl;
 // }
 // else
 // {
  // cout << "边长不能构成三角形" << endl;
 // }
 cout << endl;

 return 0;
}