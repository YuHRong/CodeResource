// Write a C++ program to find the area of the Scalene Triangle.

#include <iostream>>
#include <cmath>

#define PI 3.1415926

using namespace std;

int main()
{
 double a, b, angle, area;

 cout << "Find the area of Scalene Triangle :\n";
 cout << "----------------------------------------\n";

 cout << "Input the length of a side of the triangle : ";
 cin >> a;
 cout << "Input the length of another side of the triangle : ";
 cin >> b;
 cout << "Input the angle between these sides of the triangle : ";
 cin >> angle;

 area = (a * b * sin((PI / 180) * angle)) / 2;

 cout << "The area of the Scalene Triangle is : " << area << endl;

 return 0;
}