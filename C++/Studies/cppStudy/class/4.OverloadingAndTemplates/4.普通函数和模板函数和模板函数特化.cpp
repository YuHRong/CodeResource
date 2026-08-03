// 、重载与模板的匹配规则
// 1. 优先级规则
// 在函数重载与模板函数之间进行选择时，编译器遵循以下优先级规则：
// 1.  普通函数优先于模板函数：如果存在一个普通函数与模板函数都能匹配调用参数，编译器会优先选择普通函数。
// 2.  特化模板函数优先于通用模板函数 ：如果存在一个特化模板函数与通用模板函数都能匹配调用参数，编译器会优先选择特化模板函数。

#include <iostream>

// 普通函数
void print(double d)
{
 std::cout << "Ordinary Function: " << d << std::endl;
}

// 通用模板函数
template <typename T>
void print(T t)
{
 std::cout << "Template: " << t << std::endl;
}

// 模板函数特化，处理整形
template <>
void print(int i)
{
 std::cout << "Specialized Template: " << i << std::endl;
}

int main()
{
 print(10);      // 调用特化的模板函数，输出 "Specialized Template: 10"
 print(3.14);    // 调用普通函数，输出 "Ordinary Function: 3.14"
 print("Hello"); // 调用通用模板函数，输出 "Template: Hello"

 return 0;
}