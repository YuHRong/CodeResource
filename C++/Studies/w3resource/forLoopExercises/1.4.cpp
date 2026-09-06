// Write a C++ program that prints the first 10 natural numbers in a single line with a comma separating them.

#include <iostream>

int printNaturalNumbers(int n)
{
 if (n > 10)
  return 0;
 std::cout << n << ',';
 return printNaturalNumbers(n + 1);
}

int main()
{
 std::cout << "\n\n Find the first 10 natural numbers in a single line with a comma separating them:\n";
 std::cout << "----------------------------------------------------\n";

 printNaturalNumbers(1);

 std::cout << '\n';

 return 0;
}