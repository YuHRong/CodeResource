// Write a C++ program to find the third angle of a triangle.

#include <iostream>

using namespace std;

int main()
{
 double angle1, angle2, angle3 = 0;

 cout << "Find the third angle of a triangle :\n";
 cout << "-----------------------------------------\n";

 cout << "Input the 1st angle of the triangle : ";
 cin >> angle1;
 cout << "Input the 2nd angle of the triangle : ";
 cin >> angle2;

 angle3 = 180 - (angle1 + angle2);

 cout << "The 3rd of the triangle is : " << angle3 << endl;

 return 0;
}