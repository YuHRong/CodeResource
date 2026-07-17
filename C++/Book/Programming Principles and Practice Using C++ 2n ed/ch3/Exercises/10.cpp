// Write a program that takes an operationeration followed by two operationerands and outputs the result. For example:
// + 100 3.14
// * 4 5
// Read the operationeration into a string called operationeration and use an if-statement to figure out which operationeration the user wants, for example, if (operationeration=="+"). Read the operationerands into variables of type double. Implement this for operationerations called +, ¨C, *, /, plus, minus, mul, and div with their obvious meanings.

#include <iostream>
#include <string>

int main()
{
 double n1, n2;
 std::string operation;

 std::cout << "Please enter an operation (+, -, *, /, plus, minus, mul, div) "
           << "followed by two numbers (e.g., + 100 3.14):\n";
 std::cin >> operation;

 // std::cout << "Input two numbers, please";
 std::cin >> n1 >> n2;

 if (operation == "+" || operation == "plus")
 {
  std::cout << n1 << " + " << n2 << " = " << n1 + n2 << std::endl;
 }
 else if (operation == "-" || operation == "minus")
 {
  std::cout << n1 << " - " << n2 << " = " << n1 - n2 << std::endl;
 }
 else if (operation == "*" || operation == "mul")
 {
  std::cout << n1 << " * " << n2 << " = " << n1 * n2 << std::endl;
 }
 else if (operation == "/" || operation == "div")
 {
  std::cout << n1 << " / " << n2 << " = " << n1 / n2 << std::endl;
 }
 else
 {
  std::cout << "Operators I don't know. Retype." << std::endl;
 }

 return 0;
}