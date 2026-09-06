// Write a C++ program to calculate the sum of the first 10 natural numbers using a for loop.

#include <iostream>

int main()
{
 int sum = 0;

 std::cout << "\n\n Calculate the sum of the first 10 natural numbers using a for loop:\n";
 std::cout << "----------------------------------------------------\n";

 for (int i = 1; i <= 10; i++)
 {
  sum += i;
 }

 std::cout << "The sum of the first 10 natural numbers is: " << sum << std::endl;
}