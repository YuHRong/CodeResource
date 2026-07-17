// Write a program that prompts the user to enter two integer values. Store these values in int variables named val1 and val2. Write your program to determine the smaller, larger, sum, difference, product, and ratio of these values and report them to the user.

#include <iostream>

using namespace std;

int main()
{
 // …Í√˜±‰¡ø
 int val1, val2, smaller, larger, sum, difference, product, ratio;

 cout << "Input the val1 : ";
 cin >> val1;
 cout << "Input the val2 : ";
 cin >> val2;

 if (val1 >= val2)
 {
  larger = val1;
  smaller = val2;
 }
 else
 {
  smaller = val1;
  larger = val2;
 }

 cout << val1 << " and " << val2 << " " << endl;
 cout << "smaller value is " << smaller << endl;
 cout << "larger value is " << larger << endl;

 cout << val1 << " + " << val2 << " ";
 sum = val1 + val2;
 cout << "Sum = " << sum << endl;

 cout << val1 << " - " << val2 << " ";
 difference = val1 - val2;
 cout << "difference = " << difference << endl;

 cout << val1 << " * " << val2 << " ";
 product = val1 * val2;
 cout << "Product = " << product << endl;

 cout << val1 << " / " << val2 << " ";
 ratio = val1 / val2;
 cout << "ratio = " << ratio << endl;

 return 0;
}