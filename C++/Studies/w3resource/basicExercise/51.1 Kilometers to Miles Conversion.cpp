// Write a C++ program that converts kilometers per hour to miles per hour

#include <iostream>

const double kilometer_miles = 0.621371;
const double mile_kilometer = 1.609344;

int main()
{
 using namespace std;

 double kilometers, mile;

 cout << "Convert kilometers per hour to miles per hour :\n";
 cout << "----------------------------------------------------\n";

 cout << "Input the distance in kilometer : ";
 cin >> kilometers;

 mile = kilometers * kilometer_miles;

 cout << "The " << kilometers << " Km./hr. means " << mile << " Miles/hr." << endl;

 return 0;
}