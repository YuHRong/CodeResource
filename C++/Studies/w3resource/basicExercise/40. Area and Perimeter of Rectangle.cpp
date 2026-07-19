// Write a C++ program to print the area and perimeter of a rectangle.

#include <iostream>

using namespace std;

int main()
{
 double height, width, area, perimeter;

 cout << "Print the area and perimeter of a rectangle:\n";
 cout << "----------------------------------------------\n";

 cout << "Input the width of the rectangle: ";
 cin >> width;
 cout << "Input the height of the rectangle: ";
 cin >> height;

 area = width * height;
 cout << "The area of the rectangle is: " << area << endl;

 perimeter = (width + height) * 2;
 cout << "The perimeter of the rectangle is: " << perimeter << endl;

 return 0;
}