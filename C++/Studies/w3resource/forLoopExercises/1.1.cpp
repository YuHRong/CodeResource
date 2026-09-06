// Write a C++ program to print the first 10 natural numbers using recursion.

#include <iostream>

int printNaturalNumbers(int n)
{

 if (n > 10)
 { // Base case: If n is greater than 10, stop the recursion
  return 0;
 }
 std::cout << n << " ";             // Print the current number
 return printNaturalNumbers(n + 1); // Recursive call with the next number
}
int main()
{
 std::cout << "\n\n Find the first 10 natural numbers using recursion:\n";
 std::cout << "----------------------------------------------------\n";

 printNaturalNumbers(1); // Start the recursion with the first natural number

 std::cout << '\n';

 return 0;
}
