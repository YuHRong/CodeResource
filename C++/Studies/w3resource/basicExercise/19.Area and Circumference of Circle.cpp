// Write a C++ program to find the area and circumference of a circle.

#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
 double radius, circumference = 0, area = 0;
double pi = 3.1415926;
 cout << fixed << setprecision(4);
 cout << "Find the area and circumference of any circle :\n";
 cout << "----------------------------------------------------\n";

 cout << "Input the radius(1/2 of diameter) of a circle : ";
 cin >> radius;

 area = pi * (radius * radius);
 cout << "The area of the circle is : " << area << endl;

 circumference = 2 * pi * radius;
 cout << "The circumference of the circle is : " << circumference << endl;

 return 0;
}