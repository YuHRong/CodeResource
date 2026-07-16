// Write a program in C++ to convert temperature in Fahrenheit to Kelvin.

#include <iostream>

using namespace std;

int main()
{
 double f, k;

 cout << "Convert temperature in Fahrenheit to Kelvin :\n";
 cout << "---------------------------------------------------\n";

 cout << "Input the temperature in Fahrenheit : ";
 cin >> f;

 cout << "The temperature in Fahrenheit : " << f << endl;

 k = ((f - 32) * 5 / 9) + 273.15;

 cout << "The temperature in Kelvin : " << k << endl;

 return 0;
}