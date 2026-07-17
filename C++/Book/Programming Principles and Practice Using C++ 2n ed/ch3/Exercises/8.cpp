// Write a program to test an integer value to determine if it is odd or even. As always, make sure your output is clear and complete. In other words, don¡¯t just output yes or no. Your output should stand alone, like The value 4 is an even number. Hint: See the remainder (modulo) operator in ¡ì3.4.

#include <iostream>

using namespace std;

int main()
{
 int n;

 cout << "Input a intger : ";
 cin >> n;

 if (n % 2 == 0)
 {
  cout << "The value " << n << " is an even number." << endl;
 }
 else
 {
  cout << "The value " << n << " is an odd number." << endl;
 }

 return 0;
}