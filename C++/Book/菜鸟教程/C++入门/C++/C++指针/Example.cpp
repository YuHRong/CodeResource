#include <iostream>

using namespace std;

int main()
{
 int var = 20; // 实际变量的声明
 int *ip;      // 指针变量的声明

 ip = &var; // 在指针变量中存储 var 的地址

 cout << "var 变量的值: ";
 cout << var << endl;

 // 输出在指针变量中存储的地址
 cout << "存储在 ip 中的地址： ";
 cout << ip << endl;

 // 访问指针中地址的值
 cout << "*ip 变量的值: ";
 cout << *ip << endl;

 return 0;
}