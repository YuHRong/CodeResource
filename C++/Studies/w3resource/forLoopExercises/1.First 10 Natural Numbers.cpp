// Write a program in C++ to find the first 10 natural numbers.

#include <iostream>

using namespace std;

int main()
{
 cout << "\n\n Find the first 10 natural numbers:\n";
 cout << "---------------------------------------\n";
 
 cout << "The natural numbers are:" << endl;

 for (int i = 1; i <= 10; i++)
 {
  cout << i << " ";
 }
 cout << endl;

 return 0;
}