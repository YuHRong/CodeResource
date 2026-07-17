// Write a C++ program to input a single-digit number and print it in a rectangular form of 4 columns and 6 rows.

#include <iostream>

using namespace std;

int main()
{
 int n;

 cout << "Make a rectangular shape by a single digit number :\n";
 cout << "--------------------------------------------------------\n";

 cout << "Input the number : ";
 cin >> n;

 cout << n << n << n << n << endl;

 for (int i = 0; i < 4; i++)
  cout << n << " " << n << endl;

 cout << n << n << n << n << endl;

 return 0;
}