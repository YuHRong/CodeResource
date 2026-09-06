// Write a program in C++ to find the sum of the first 10 natural numbers.\

#include <iostream>

using namespace std;

int main()
{
 int i, sum = 0; // 申明两个整数变量并初始化 sum 为 0

 cout << "Find the first 10 natural numbers:" << endl;
 cout << "---------------------------------------" << endl;

 cout << "The natural numbers are:" << endl;

 for (i = 1; i <= 10; i++)
 {
  cout << i << " ";

  // 将从 1 开始的 i 附加给 sum
  sum += i; // 等同于 sum = sum + i;
 }
 cout << "\n\nThe sum of first 10 natural numbers: " << sum << endl;
 cout << endl;

 return 0;
}