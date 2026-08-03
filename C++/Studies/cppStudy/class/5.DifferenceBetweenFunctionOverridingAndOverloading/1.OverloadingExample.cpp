#include <iostream>

// 无参数重在函数
void print()
{
 std::cout << "No parameters" << std::endl;
}

// 一个整形参数重在函数
void print(int i)
{
 std::cout << "Integer: " << i << std::endl;
}

// 一个双精度浮点数重在函数
void print(double d)
{
 std::cout << "Double: " << d << std::endl;
}

// 两个整形参数重在函数
void print(int i, int j)
{
 std::cout << "Two integers: " << i << ", " << j << std::endl;
}

int main()
{
 print();
 print(10);
 print(3.14);
 print(5, 15);

 return 0;
}