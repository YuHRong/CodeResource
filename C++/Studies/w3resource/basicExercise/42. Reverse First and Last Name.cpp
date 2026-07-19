// Write a C++ program that accepts the user's first and last name and prints them in reverse order with a space between them.

#include <iostream>

using namespace std;

int main()
{
 cout << "Print the name in reverse where last name comes first:\n";
 cout << "-----------------------------------------------------------\n";

 string first_name, last_name;

 cout << "Input first name: ";
 cin >> first_name;
 cout << "Input last name: ";
 cin >> last_name;

 cout << "Name in reverse is: " << last_name << " " << first_name << endl;

 return 0;
}