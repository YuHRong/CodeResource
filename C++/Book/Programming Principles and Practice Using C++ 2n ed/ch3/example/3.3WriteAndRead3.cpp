// read name and age (2nd version)
#include <iostream>

using namespace std;

int main()
{
 cout << "Please enter your first name and age\n";

// string first_name = "???"; // 字符串变量
 // (???表示不知道名字)
 // int age = -1; // 整数变量 (-1 表示不知道年龄))

string first_name;
double age;
 cin >> first_name >> age; // 读取一个字符串和一个整数变量
double age_month = age * 12;

cout << "Hello, " << first_name << " , you are " << age_month << " motns old.\n";

  return 0;
}