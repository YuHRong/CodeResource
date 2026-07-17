// Write a program in C++ to check whether a number is positive, negative or zero.

#include <iostream>

using namespace std;

int main()
{
 int n;

 cout << "Check whether a number is positive, negative or zero :\n";
 cout << "-----------------------------------------------------------\n";

 cout << "Input a number : ";
 cin >> n;

 if (n > 0)
  cout << "The entered number is positive.\n" << endl;
 else if (n < 0)
  cout << " The entered number is negative.\n" << endl;
 else
  cout << "The number is zero." << endl;

 cout << endl;

 return 0;
}