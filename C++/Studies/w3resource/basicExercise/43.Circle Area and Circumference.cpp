// Write a C++ program that accepts the radius of a circle from the user and computes the area and circumference.

#include <iostream>

#define PI 3.14159

using namespace std;

int main()
{
 double r, area, circumference;

 cout << "Find the area and circumference of any circle :\n";
 cout << "----------------------------------------------------\n";

 cout << "Input the radius(1/2 of diameter) of a circle : ";
 cin >> r;

 area = (r * r) * PI;
 cout << "The area of the circle is : " << area << endl;

 circumference = 2 * r * PI;
 cout << "The circumference of the circle is : " << circumference << endl;

 return 0;
}