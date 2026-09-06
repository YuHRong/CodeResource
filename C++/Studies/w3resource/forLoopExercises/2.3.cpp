// Write a C++ program that sums the first 10 natural numbers and prints the result in a formatted box.
#include <iostream>

int main()
{
    int sum = 0;

    // Calculate the sum of the first 10 natural numbers
    for (int i = 1; i <= 10; ++i)
    {
        sum += i;
    }

    // Print the result in a formatted box
    std::cout << "------------------------\n";
    std::cout << "| Sum of first 10 natural numbers |\n";
    std::cout << "------------------------\n";
    std::cout << "| Result: " << sum << " |\n";
    std::cout << "------------------------\n";

    return 0;
}