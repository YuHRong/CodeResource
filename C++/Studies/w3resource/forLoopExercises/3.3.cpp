// Write a C++ program that prompts for n and then prints the sequence of natural numbers along with a running total on each line.

#include <iostream>

int main()
{
 int n{};
 int sum{0};

 // Prompt the user for input
 std::cout << "Enter a positive integer n: ";
 std::cin >> n;

 // Validate input
 if (n <= 0)
 {
  std::cout << "Please enter a positive integer." << std::endl;
  return 1; // Exit the program with an error code
 }

 // Print the sequence of natural numbers along with a running total
 std::cout << "Natural numbers and their running total:\n";
 std::cout << "----------------------------------------\n";
 for (int i = 1; i <= n; ++i)
 {
  sum += i;
  std::cout << "Number: " << i << ", Running Total: " << sum << "\n";
 }
 std::cout << "----------------------------------------\n";

 return 0;
}