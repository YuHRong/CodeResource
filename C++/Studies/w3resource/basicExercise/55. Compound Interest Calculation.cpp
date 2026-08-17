// Write a C++ program to enter P, T, R and calculate compound interest.

#include <iostream>
#include <cmath>

using std::cin;
using std::cout;
using std::endl;

int main()
{
 double p, t, r, compound, interest;

 cout << "Calculate the Compound Interest :\n";
 cout << "-------------------------------------\n";

 cout << "Input the Principle: ";
 cin >> p;
 cout << "Input the Rate of Interest: ";
 cin >> r;
 cout << "Input the Time : ";
 cin >> t;

 interest = p * pow((1 + r / 100), t) - p;
 compound = p * pow((1 + r / 100), r);

 cout << " The Interest after compounded for the amount " << p << " for " << t << " years @ " << r << " % is: " << interest << endl;
 cout << " The total amount after compounded for the amount " << p << " for " << t << " years @ " << r << " % is: " << compound << endl;

 return 0;
}