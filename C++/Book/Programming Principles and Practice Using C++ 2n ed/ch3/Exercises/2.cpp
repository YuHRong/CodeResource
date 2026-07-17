// Write a program in C++ that converts from miles to kilometers. Your program should have a reasonable prompt for the user to enter a number of miles.
// Hint: There are 1.609 kilometers to the mile.

#include <iostream>

using namespace std;

int main()
{
 double kilometer, mile;

 cout << "Input the mile : ";
 cin >> mile;

 kilometer = mile * 1.609;

 cout << mile << " mile = " << kilometer << " kilometers" << endl;

 return 0;
}