// Write a C++ program to print the first n natural numbers and calculate their sum using a for loop with dynamic input.

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

 // Calculate the sum of the first n natural numbers
 for (int i = 1; i <= n; ++i)
 {
  sum += i;
 }

 // Print the result in a formatted box
 std::cout << "------------------------\n";
 std::cout << "| Sum of first " << n << " natural numbers |\n";
 std::cout << "------------------------\n";
 std::cout << "| Result: " << sum << " |\n";
 std::cout << "------------------------\n";

 return 0;
}