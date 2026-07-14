// Write a C++ program that swaps two numbers.

#include <iostream>

using namespace std;

int main()
{
 // 申明两个变量存储数字，申明一个中间变量
 double n1, n2, t;

 cout << "\n\n Swap two numbers :\n"; // Outputting a message indicating swapping of two numbers
 cout << "-----------------------\n"; // Outputting a separator line

 cout << "Input 1st number : ";
 cin >> n1;

 cout << "Input 2nd number :";
 cin >> n2;

 t = n1;
 n1 = n2;
 n2 = t;

 cout << "After swapping the 1st number is : " << n1 << endl;
 cout << "After swapping the 2nd number is : " << n2 << endl;

 return 0;
}