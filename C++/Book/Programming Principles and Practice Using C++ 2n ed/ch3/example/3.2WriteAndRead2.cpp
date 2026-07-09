// 写入名字和年龄并打印
#include <iostream>

using namespace std;

int main()
{
 cout << "Please enter your first name and age\n";

 string first_name; // 字符串变量
 int age;           // integer 变量

 cin >> first_name; // 读取 string
 cin >> age;        // 读取 integer

 cout << "Hello, " << first_name << " (age " << age << ")\n";

 return 0;
}