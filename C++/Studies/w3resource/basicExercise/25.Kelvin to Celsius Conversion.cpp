// Write a program in C++ to convert temperature in Kelvin to Celsius.

#include <iostream>

using namespace std;

int main()
{
 double k, c;

 cout << "Convert temperature in Kelvin to Celsius :\n";
 cout << "------------------------------------------------\n";

 cout << "Input the temperature in Kelvin : ";
 cin >> k;

 cout << "The temperature in Kelvin : " << k << endl;

 c = k - 273.15;

 cout << "The temperature in Celsius : " << c << endl;

 return 0;
}