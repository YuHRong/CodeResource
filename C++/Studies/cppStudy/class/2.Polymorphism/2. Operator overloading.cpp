// 运算符重载允许用户自定义运算符的行为，以便能够在特定类型的对象上使用运算符。

#include <iostream>

using namespace std;

class Complex
{
private:
 float real;
 float imag;

public:
 Complex(float r = 0, float i = 0) : real(r), imag(i)
 {
 }

 // 运算符重在
 Complex operator+(const Complex &obj)
 {
  return Complex(real + obj.real, imag + obj.imag);
 }

 void display()
 {
  cout << real << " + " << imag << "i" << endl;
 }
};

int main()
{
 Complex c1(1.2, 3.4);
 Complex c2(5.6, 7.8);
 Complex c3 = c1 + c2; // 调用重在的 + 运算符

 c3.display(); // 输出 6.8 + 11.2i

 return 0;
}