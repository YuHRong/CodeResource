// Write a C++ program to convert temperature in Fahrenheit to Celsius.

#include <iostream>

using namespace std;

int main()
{
 double f, c = 0;

 cout << "Convert temperature in Fahrenheit to Celsius :\n";
 cout << "---------------------------------------------------\n";

 cout << "Input the temperature in Fahrenheit : ";
 cin >> f;

 cout << "The temperature in Fahrenheit : " << f << endl;

 c = (f - 32) * (5.0 / 9.0);

 cout << "The temperature in Celsius : " << c << endl;

 return 0;
}