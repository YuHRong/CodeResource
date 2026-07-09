// read first and second name
#include <iostream>

using namespace std;

int main()
{
 cout << "Please enter your first and second names\n";

 string first;
 string second;

 cin >> first >> second; // 读取两个字符串变量

 string name = first + ' ' + second; // 连接字符串

 cout << "Hello, " << name << '\n';

 return 0;
}