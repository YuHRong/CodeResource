// Write a C++ program to print the code (ASCII code / Unicode code etc.) of a given character.

#include <iostream>

int main()
{
 char ch;

 std::cout << "Print code (ASCII code / Unicode code etc.) of a given character:\n";
 std::cout << "-----------------------------------------------------------------------\n";

 std::cout << "Input a character: ";
 std::cin >> ch;

 std::cout << "The ASCII value of " << ch << " is: " << (int)ch << std::endl;
 std::cout << "The ASCII value of " << ch << " is: " << static_cast<int>(ch) << std::endl;

 return 0;
}