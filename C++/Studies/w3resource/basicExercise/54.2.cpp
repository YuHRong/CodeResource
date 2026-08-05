// Write a C++ program to compute simple interest, including error handling for negative principal, rate, or time values.

#include <iostream>

int main()
{
 double p, t, r, a;

 std::cout << "Input the principal: ";
 std::cin >> p;
 if (p <= 0)
 {
  std::cout << "Error: value is not <= 0" << std::endl;
  return 1;
 }

 std::cout << "Input the rate: ";
 std::cin >> r;
 if (r <= 0)
 {
  std::cout << "Error: value is not <= 0" << std::endl;
  return 1;
 }

 std::cout << "Input the time: ";
 std::cin >> t;
 if (t <= 0)
 {
  std::cout << "Error: value is not <= 0" << std::endl;
  return 1;
 }

 a = (p * t * r) / 100;

 std::cout << "The Simple interest for the amount " << p << " for " << t << " years @ " << r << " % is: " << a << std::endl;

 return 0;
}