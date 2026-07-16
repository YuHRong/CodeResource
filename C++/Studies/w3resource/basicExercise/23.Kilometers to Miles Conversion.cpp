// Write a program in C++ that converts kilometers per hour to miles per hour.

#include <iostream>

using namespace std;

int main()
{
 double kilometer, mile = 0;

 cout << "Convert kilometers per hour to miles per hour :\n";
 cout << "----------------------------------------------------\n";

 cout << "Input the distance in kilometer : ";
 cin >> kilometer;

 mile = kilometer * (1.0 / 1.609344);

 cout << "The " << kilometer << " Km./ hr.means " << mile << " Miles / hr." << endl;

 return 0;
}