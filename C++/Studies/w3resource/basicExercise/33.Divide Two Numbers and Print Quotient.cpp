// Write a program in C++ to divide two numbers and print them on the screen.

#include <iostream> // Including input-output stream header file

using namespace std; // Using the standard namespace

int main() // Start of the main function
{
 cout << "\n\n Divide two numbers and print:\n"; // Outputting a message indicating the purpose of the program
 cout << "----------------------------------\n"; // Outputting a separator line

 int a;      // Declaring an integer variable a
 int b;      // Declaring an integer variable b
 int resdiv; // Declaring an integer variable resdiv to store the result of division

 a = 30;         // Assigning the value 30 to variable a
 b = 10;         // Assigning the value 10 to variable b
 resdiv = a / b; // Dividing variable a by variable b and storing the result in resdiv

 cout << " The quotient of " << a << " and " << b << " is : " << resdiv << "\n\n"; // Outputting the quotient of a and b

 return 0; // Returning 0 to indicate successful program execution
}