// 多态示例

#include <iostream>

class Base
{
public:
 virtual void show() // 虚函数
 {
  std::cout << "Base show" << std::endl;
 }
};

class Derived : public Base // Derived 继承自 Base
{
public:
 void show() // 重写基类的虚函数
 {
  std::cout << "Derived show" << std::endl;
 }
};

int main()
{
 Base *bptr = new Derived(); // 基类指针指向派生类对象

 bptr->show(); // 调用派生类的 show 方法

 delete bptr; // 释放内存

 return 0;
}