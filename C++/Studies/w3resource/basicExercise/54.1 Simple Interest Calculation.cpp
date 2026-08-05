// Write a C++ program to enter P, T, R and calculate Simple Interest.

#include <iostream>

using namespace std;

int main()
{
 double principle, rate, time, amount = 0;

 cout << "Calculate the Simple Interest :\n";
 cout << "-----------------------------------\n";

 cout << "Input the Principle: ";
 cin >> principle;
 cout << "Input the Rate of Interest: ";
 cin >> rate;
 cout << "Input the time: ";
 cin >> time;

 amount = (principle * rate * time) / 100;

 cout << "The Simple interest for the amount " << principle << " for " << time << " years @ " << rate << " % is: " << amount << endl;

 return 0;
}