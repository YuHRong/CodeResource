#include <iostream>

using namespace std;

// 模板函数

template <typename T>
void print(T t)
{
 cout << "Template: " << t << endl;
}

int main()
{
 print(10);      // 实例化模板函数 T 为 int
 print(3.14);    // 实例化模板函数 T 为 double
 print("Hello"); // 实例化模板函数 T 为 const cchar*

 return 0;
}

// 在上例中， print  函数是一个模板函数，可以接受任意类型的参数。在调用时，编译器会根据传递的参数类型实例化相应的模板函数。