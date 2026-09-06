// Write a C++ program to display the first 10 natural numbers in reverse order.

#include <iostream>

int printNaturalNumber(int n)
{
 if (n < 1) // Base case: If n is less than 1, stop the recursion
  return 0;
 std::cout << n << " ";            // Print the current number
 return printNaturalNumber(n - 1); // Recursive call with the previous number
}

int main()
{
 std::cout << "\n\n Find the first 10 natural numbers in reverse order using recursion:\n";
 std::cout << "----------------------------------------------------\n";

 printNaturalNumber(10); // Start the recursion with the last natural number

 std::cout << '\n';

 return 0;
}