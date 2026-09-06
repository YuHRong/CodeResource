// Write a C++ program to display both the list of the first 10 natural numbers and their cumulative sum using a while loop.

#include <iostream>

int main()
{
 int sum{0};

 // 打印题目
 std::cout << "List of the first 10 natural numbers and their cumulative sum:\n";
 std::cout << "---------------------------------------------\n";

 int i{1};
 while (i <= 10)
 {
  std::cout << i << " ";
  sum += i;
  ++i;
 }
 std::cout << "\nCumulative Sum: " << sum << std::endl;
 return 0;
}