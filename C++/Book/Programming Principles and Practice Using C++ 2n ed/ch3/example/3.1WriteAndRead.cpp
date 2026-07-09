// read and write a first name
#include <iostream>

using namespace std;

int main()
{
 cout << "Please enter your first name (followed by 'enter'):\n";
 string first_name; // first_name 是字符串变量
 cin >> first_name; // 将字符读入 first_name
 cout << "Hello, " << first_name << "!\n";
 return 0;
}