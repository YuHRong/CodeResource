// 模板函数还可以进行特化，即为特定类型提供特化版本，从而实现特定类型的特殊处理。

#include <iostream>

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
 print(3.14);    // 调用通用模板函数，输出 "Template: 3.14"
 print("Hello"); // 调用通用模板函数，输出 "Template: Hello"

 return 0;
}

// 在这个例子中，
// 特化版本的 print 函数专门处理整型。
// 当调用 print(10) 时，编译器会选择特化版本的模板函数，
// 而对于其他类型，编译器会选择通用模板函数。