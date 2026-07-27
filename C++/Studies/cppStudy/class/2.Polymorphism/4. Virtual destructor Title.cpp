// 在基类中定义虚析构函数非常重要，尤其是在使用基类指针删除派生类对象时，可以确保派生类的析构函数被正确调用。

#include <iostream>

using namespace std;

class Base
{
public:
 virtual ~Base()
 { // 虚析构函数
  cout << "Base destructor called!" << endl;
 }
};

class Derived : public Base
{
public:
 ~Derived()
 {
  cout << "Derived destructor called!" << endl;
 }
};

int main()
{
 Base *b = new Derived(); // 基类指针指向派生类对象

 delete b; // 调用 Derived 的析构函数，然后调用 Base 的析构函数

 return 0;
}