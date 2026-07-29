// 1. Write a program that consists of a while-loop that (each time around the loop) reads in two ints and then prints them. Exit the program when a terminating '|' is entered.
// 5. Change the program so that it writes out the numbers are almost equal after writing out which is the larger and the smaller if the two numbers differ by less than 1.0/100.

#include "std_lib_facilities.h"

int main()
{
 string input1, input2;
 const double t = 1.0 / 100;
 double temp;

 while (true)
 {
  cout << "Enter two double numbers: \n";

  cin >> input1;
  if (input1 == "|")
   break;

  cin >> input2;
  if (input2 == "|")
   break;

  // 将string 转换为 int类型
  // int num1 = stoi(input1);
  // int num2 = stoi(input2);

  // 4.改变程序：输入的数据改为double型而不是int型。
  // 将 string 类型 转换为 double 类型
  double num1 = stod(input1);
  double num2 = stod(input2);

  // cout << "your enter " << num1 << '\t' << num2 << '\n';

  cout << num1 << " and " << num2 << '\n';

  // 2. Change the program to write out the smaller value is: followed by the smaller of the numbers and the larger value is: followed by the larger value.
  // 3. Augment the program so that it writes the line the numbers are equal (only) if they are equal.
  // int largest, smallest;

  // 将 largest 和 smallest 修改为 double 类型
  double largest, smallest;

  if (num1 == num2)
  {
   cout << "The numbers are equal\n";
  }
  else if (abs(num1 - num2) < t)
  {
   cout << "The numbers are almost equal\n";
  }
  else if (num1 > num2)
  {
   largest = num1;
   smallest = num2;

   cout << "Thesmaller value is : " << smallest << '\n';
   cout << "The larger value is: " << largest << '\n';
  }
  else
  {
   largest = num2;
   smallest = num1;

   cout << "Thesmaller value is : " << smallest << '\n';
   cout << "The larger value is: " << largest << '\n';
  }
 }
 cout << "Bye.\n";

 return 0;
}