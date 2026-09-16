#include <iostream>

class Box
{
public:
 Box() { std::cout << "调用构造函数！" << std::endl; }
 ~Box() { std::cout << "调用析构函数！" << std::endl; }
};

int main()
{
 Box *myBox = new Box(); // 动态分配 Box 对象，调用构造函数
 delete myBox;           // 释放内存，调用析构函数

 Box *myBoxArray = new Box[4]; // 动态分配Box对象数组，调用4次构造函数
 delete[] myBoxArray;          // 释放数组内存，调用四次析构函数

 return 0;
}