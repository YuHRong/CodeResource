#include <iostream>

using namespace std;

// 使用引用作为函数参数
void increment(int &ref)
{
 ref++;
}

int main()
{
 int a = 10;
 increment(a);                // a 的值被修改为 11
 cout << "a = " << a << endl; // 输出 a = 11

 return 0;
}