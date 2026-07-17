// Write a C++ program to compute the total and average of four numbers.

#include <iostream>

using namespace std;

int main()
{
 double n1, n2, n3, n4, total, avg;

 cout << "Compute the total and average of four numbers :\n";
 cout << "----------------------------------------------------\n";

 cout << "Input 1st two numbers (separated by space) : ";
 cin >> n1 >> n2;

 cout << "Input last two numbers (separated by space) : ";
 cin >> n3 >> n4;

 total = n1 + n2 + n3 + n4;
 cout << "The total of four numbers is : " << total << endl;

 avg = (n1 + n2 + n3 + n4) / 4;
 cout << "The average of four numbers is : " << avg << endl;

 return 0;
}