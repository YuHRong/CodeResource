#include <iostream>

class Base
{
public:
 virtual void show()
 {
  std::cout << "Base class" << std::endl;
 }
};

class Derived : public Base
{
public:
 void show() override
 {
  std::cout << "Derived class" << std::endl;
 }
};

int main()
{
 Base *b;
 Derived d;
 b = &d;
 b->show(); // 调用 Derived 类中的 show() 函数

 return 0;
}