// 模板函数可以与普通函数一起重载。编译器会根据函数调用的参数类型和数量来选择合适的函数。
// Example

#include <iostream>

using namespace std;

// 模板函数
template <typename T>
void print(T t)
{
 cout << "Template: " << t << endl;
}

// 重在函数，处理整形
void print(int i)
{
 cout << "Overloaded: " << i << endl;
}

int main()
{
 print(10);      // 调用重在函数,输出 "Overloaded: 10"
 print(3.14);    // 调用模板函数，输出 Template: 3.14
 print("Hello"); // 调用模板函数，输出Template: Hello

 return 0;
}

// 在这个例子中，
// 当调用 print(10) 时，编译器会选择匹配参数类型最精确的重载函数，即处理整型的 print 函数。
// 而对于 print(3.14) 和
// print("Hello")  ，
// 编译器会选择模板函数，因为没有更精确的普通函数重载。