// 虚函数是通过在基类中声明为  virtual   的成员函数。虚函数使得 C++ 能够在基类指针或引用调用时，决定调用派生类中的重写函数。

#include <iostream>

using namespace std;

class Base
{
public:
 virtual void show()
 { // 基类中的虚函数
  cout << "Base class show function." << endl;
 }

 virtual ~Base() {} // 虚析构函数
};

class Derived : public Base
{
public:
 void show() override
 {
  cout << "Derived class show function." << endl;
 }
};

int main()
{
 Base *b;   // 基类指针
 Derived d; // 派生类对象

 b = &d; // 基类指针指向派生类对象

 // 使用基类指针调用虚函数
 b->show(); // 输出: "Derived class show function."

 return 0;
}