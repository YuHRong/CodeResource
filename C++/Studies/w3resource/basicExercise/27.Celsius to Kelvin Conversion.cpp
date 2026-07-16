// Write a program in C++ to convert temperature in Celsius to Kelvin.

#include <iostream>

using namespace std;

int main()
{
 double c, k;

 cout << "Convert temperature in Celsius to Kelvin :\n";
 cout << "---------------------------------------------------\n";

 cout << "Input the temperature in Celsius : ";
 cin >> c;

 cout << "The temperature in Celsius : " << c << endl;

 k = c + 273.15;

 cout << "The temperature in Kelvin : " << k << endl;
 cout << endl;

 return 0;
}