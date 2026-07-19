// Write a C++ program that takes a number as input and prints its multiplication table up to 10.

#include <iostream>

using namespace std;

int main()
{
 int n;

 cout << "Print the multiplication table of a number upto 10:\n";
 cout << "--------------------------------------------------------\n";

 cout << "Input a number : ";
 cin >> n;

 for (int i = 1; i <= 10; i++)
 {
  cout << n << " x " << i << " = " << n * i << endl;
 }

 return 0;
}