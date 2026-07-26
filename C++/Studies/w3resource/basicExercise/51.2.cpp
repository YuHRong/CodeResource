// Write a C++ program that converts kilometers per hour to miles per hour using user-defined functions and error-checks negative inputs.

#include <iostream>

using namespace std;

// 定义公里转英里数值为常量
const double KILOMETER_TO_MILE = 0.621371;

// 函数申明
double kilometer_convert_mile(double n);

int main()
{
 double km;

 cout << "Input the value in kilometer per  hour : ";
 cin >> km;

 if (km <= 0)
 {
  cerr << "输入的值有误\n";
  return 1;
 }

 // 调用函数
 double miles = kilometer_convert_mile(km);

 cout << "The " << km << " Km./hr. means " << miles << " miles/hr." << endl;

 return 0;
}

// 函数定义
double kilometer_convert_mile(double n)
{
 return n * KILOMETER_TO_MILE;
}