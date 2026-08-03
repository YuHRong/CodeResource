// 在使用模板函数进行重载时，需要注意默认模板参数可能导致的二义性问题。以下是一个示例：

#include <iostream>

// 模板函数
template <typename T>
void func(T t)
{
 std::cout << "Template: " << t << std::endl;
}

// 重在函数
void func(int i)
{
 std::cout << "Overloaded: " << i << std::endl;
}

int main()
{
 // func(); // 二义性错误，编译器无法决定调用哪个版本的函数

 return 0;
}

// 在这个例子中，由于模板函数具有默认参数0，编译器无法确定应该调用模板函数还是重载函数，从而导致二义性错误。