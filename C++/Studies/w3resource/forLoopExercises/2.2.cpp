// Write a C++ program to compute the sum of the first 10 natural numbers using recursion.
#include <iostream>

int printNaturalNumbersSum(int n)
{
 if (n > 10)
  return 0;
 std::cout << n << ',';
 return n + printNaturalNumbersSum(n + 1);
}

int main()
{
 int n = 1;

 // 打印题目
std::cout << "Compute the sum of the first 10 natural numbers using recursion.\n";
std::cout << "------------------------------------------------\n";

 std::cout << "The first 10 natural numbers are: ";
 printNaturalNumbersSum(n);
 std::cout << '\n';
 return 0;
}