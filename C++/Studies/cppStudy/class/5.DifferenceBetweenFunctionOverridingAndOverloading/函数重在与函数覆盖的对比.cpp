#include <iostream>

class Base
{
public:
 // 重载函数，基类中有两个同名函数，参数不同
 void display()
 {
  std::cout << "Display without parameters in Base" << std::endl;
 }

 void display(int i)
 {
  std::cout << "Display with int parameter in Base: " << i << std::endl;
 }

 // 虚函数，准备在派生类中进行覆盖
 virtual void show()
 {
  std::cout << "Show in Base" << std::endl;
 }
};

class Derived : public Base
{
public:
 // 重载函数，派生类中有两个同名函数，参数不同
 void display()
 {
  std::cout << "Display without parameters in Derived" << std::endl;
 }

 void display(double d)
 {
  std::cout << "Display with double parameter in Derived: " << d << std::endl;
 }

 // 覆盖函数，重新定义基类中的虚函数
 void show() override
 {
  std::cout << "Show in Derived" << std::endl;
 }
};

int main()
{
 Base b;
 Derived d;

 // 调用基类中的重载函数
 b.display();
 b.display(100);

 // 调用派生类中的重载函数
 d.display();
 d.display(3.14);

 // 调用基类和派生类中的覆盖函数
 Base *ptr = &d;
 ptr->show(); // 输出 "Show in Derived" 表明调用的是派生类的覆盖函数

 return 0;
}