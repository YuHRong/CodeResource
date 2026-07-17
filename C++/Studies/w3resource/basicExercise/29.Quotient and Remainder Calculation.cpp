// Write a C++ program to compute the quotient and remainder.

#include <iostream>

using namespace std;

int main()
{
 int dividend, divisor, quotient, remainder;

 cout << "Compute quotient and remainder :\n";
 cout << "-------------------------------------\n";

 cout << "Input the dividend : ";
 cin >> dividend;

 cout << "Input the divisor : ";
 cin >> divisor;

 quotient = dividend / divisor;

 cout << "The quotient of the division is : " << quotient  << endl;

 remainder = dividend % divisor;

 cout << "The remainder of the division is : " << remainder << endl;

 return 0;
}