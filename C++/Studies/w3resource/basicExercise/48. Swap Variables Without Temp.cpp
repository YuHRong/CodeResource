// Write a C++ program that swaps two variables without using a third variable.

#include <iostream>

int main()
{

 int n1, n2;

 std::cout << "Swap two numbers without using third variable:\n";
 std::cout << "---------------------------------------------------\n";

 std::cout << "Input 1st number : ";
 std::cin >> n1;
 std::cout << "Input 2nd number : ";
 std::cin >> n2;

 n1 = n1 + n2;
 n2 = n1 - n2;
 n1 = n1 - n2;

 std::cout << "After swapping the 1st number is : " << n1 << std::endl;
 std::cout << "After swapping the 2nd number is : " << n2 << std::endl;

 return 0;
}
