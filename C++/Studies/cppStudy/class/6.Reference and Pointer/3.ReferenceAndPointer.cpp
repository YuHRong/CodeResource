#include <iostream>

using namespace std;

// 使用引用作为函数参数
void incrementRef(int &ref)
{
 ref++;
}

// 使用指针作为函数参数
void incrementPtr(int *ptr)
{
 (*ptr)++;
}

int main()
{
 int a = 10;
 int b = 20;

 // 引用
 int &ref = a;
 incrementRef(ref);
 cout << "a (after incrementRef): " << a << endl; // 输出 11

 // 指针
 int *ptr = &b;
 incrementPtr(ptr);
 cout << "b (after incrementPtr): " << b << endl; // 输出 21

 // 修改指针指向
 ptr = &a;
 incrementPtr(ptr);
 cout << "a (after incrementPtr): " << a << endl; // 输出 12

 return 0;
}