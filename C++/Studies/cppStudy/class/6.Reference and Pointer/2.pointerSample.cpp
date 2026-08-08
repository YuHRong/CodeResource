#include <iostream>

using namespace std;

// 使用指针作为函数参数
void increment(int *ptr)
{
 (*ptr)++;
}

int main()
{
 int a = 10;

 increment(&a); // 传递 a 的地址

 cout << "a = " << a << endl; // 输出 a = 11

 return 0;
}