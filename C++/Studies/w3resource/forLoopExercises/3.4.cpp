// Write a C++ program to generate an array of the first n natural numbers and then compute and display the sum of its elements.

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

 // Generate an array of the first n natural numbers
 int *naturalNumbers = new int[n];
 for (int i = 0; i < n; ++i)
 {
  naturalNumbers[i] = i + 1;
  sum += naturalNumbers[i];
 }

 // Display the array and the sum of its elements
 std::cout << "Array of the first " << n << " natural numbers:\n";
 for (int i = 0; i < n; ++i)
 {
  std::cout << naturalNumbers[i] << " ";
 }
 std::cout << "\nSum of the elements: " << sum << std::endl;

 // Clean up dynamically allocated memory
 delete[] naturalNumbers;

 return 0;
}