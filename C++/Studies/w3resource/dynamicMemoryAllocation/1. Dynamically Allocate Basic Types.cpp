// Write a C++ program to dynamically allocate an integer, a character and a string and assign a value to them.

#include <iostream>
#include <string>

int setDynamicInt();
char setDynamicChar();
std::string setDynamicString();

int main()
{
 // 打印信息
 setDynamicInt();
 setDynamicChar();
 setDynamicString();

 return 0;
}

int setDynamicInt()
{
 int *dynamicInt{new int}; // 为 int 动态分配内存并将地址存储在 dynamicInt 中
 *dynamicInt = 20;         // 为动态分配的整数赋值为20
 int returnValue{*dynamicInt};
 std::cout << "Dynamically allocated integer: " << *dynamicInt << '\n'; // 输出动态分配的整数 20
 delete dynamicInt;                                                     // 释放动态分配的 int 内存
 dynamicInt = nullptr;
 return returnValue;
}

char setDynamicChar()
{
 char *dynamicChar{new char}; // 动态为 char 字符分配内存，并将字符存储在 dynamicChar 中
 *dynamicChar = 'C';          // 将字符 'C' 分配给动态分配的内存
 char returnValue{*dynamicChar};
 std::cout << "Dynamicall allocated character: " << *dynamicChar << '\n'; // 输出动态分配的字符 C
 delete dynamicChar;                                                      // 释放动态分配的 char 内存
 dynamicChar = nullptr;
 return returnValue;
}

std::string setDynamicString()
{
 std::string *dynamicString{new std::string};                            // 为字符串分配内存，并将字符存储在 dynamicString 中
 *dynamicString = "C++ Dynamically allocated string.";                   // 为动态分配的字符串 分配一个字符串值
 std::cout << "Dynamicall allocated string: " << *dynamicString << '\n'; // 输出动态分配的字符串
 delete dynamicString;                                                   // 释放以分配的 string 内存
 dynamicString = nullptr;
 return *dynamicString;
}