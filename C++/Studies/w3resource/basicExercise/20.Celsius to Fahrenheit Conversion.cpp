// Write a C++ program to convert temperature in Celsius to Fahrenheit.

#include <iostream>

using namespace std;

int main()
{
 double c, f = 0;

 cout << "Convert temperature in Celsius to Fahrenheit :\n";
 cout << "---------------------------------------------------\n";

 cout << "Input the temperature in Celsius : ";
 cin >> c;

 f = c * 1.8 + 32;

 cout << "The temperature in Celsius : " << c << endl;
 cout << "The temperature in Fahrenheit : " << f << endl;

 return 0;
}