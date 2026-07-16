// Write a program in C++ to convert temperature in Kelvin to Fahrenheit.

#include <iostream>

using namespace std;

int main()
{
 double k, f;

 cout << "Convert temperature in Kelvin to Fahrenheit :\n";
 cout << "---------------------------------------------------\n";

 cout << "Input the temperature in Kelvin : ";
 cin >> k;

 cout << "The temperature in Kelvin : " << k << endl;

 f = ((k - 273.15) * 9 / 5) + 32;

 cout << "The temperature in Fahrenheit : " << f << endl;
 cout << endl;
}