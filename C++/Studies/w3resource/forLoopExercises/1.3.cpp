// Write a C++ program to output the first 10 natural numbers using a while loop.

#include<iostream>

int main(){
 std::cout << "\n\n Find the first 10 natural numbers using a while loop:\n";
 std::cout << "----------------------------------------------------\n";

 int n = 1;
 while(n <= 10){
std::cout << n << ' ';
n++;
 }
 std::cout << '\n';
}