// 函数重载允许在同一个作用域中定义多个同名但参数列表不同的函数。编译器根据函数调用 时提供的参数类型和数量决定调用哪个函数。

#include <iostream>

using namespace std;

class Overload
{
public:
 void func(int i)
 {
  cout << "Function with int: " << i << endl;
 }

 void func(double d)
 {
  cout << "Function with double: " << d << endl;
 }

 void func(int i, double d)
 {
  cout << "Function width int and double: " << i << " " << d << endl;
 }
};

int main()
{
 Overload obj;

 obj.func(10);       // 调用 func(int)
 obj.func(3.14);     // 调用 func(double)
 obj.func(10, 3.14); // 调用 func(int, double)

 return 0;
}