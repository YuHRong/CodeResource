// Write a C++ program to dynamically allocate an array of integers and strings and initialize its elements.

#include <iostream>
#include <string>

int main()
{
 // 动态分配整数数组
 int size = 7;                    // 数组大小
 int *dynamicInt = new int[size]; // 为整数数组动态分配内存

 // 初始化整数数组元素
 for (int i = 0; i < size; i++)
 {
  dynamicInt[i] = i + 1; // 将整数数组元素初始化为 1 到 7
 }

 // 动态分配字符串数组
 std::string *dynamicString = new std::string[size]; // 为字符串数组动态分配内存

 // 初始化字符串数组元素
 for (int i = 0; i < size; i++)
 {
  dynamicString[i] = "Element-" + std::to_string(i + 1); // //在动态分配的字符串数组中设置值
 }

 // 输出整数数组元素
 std::cout << "Dynamically allocated integer array:" << '\n';
 for (int i = 0; i < size; i++)
 {
  std::cout << dynamicInt[i] << ' '; // 输出动态分配的整数数组的每个元素
 }

 // 显示动态分配的字符串数组的元素
 std::cout << "\nDynamically allocated string array:" << '\n';
 for (int i = 0; i < size; i++)
 {
  std::cout << dynamicString[i] << ' '; // 输出动态分配的字符串数组的每个元素
 }

 // 释放动态分配的内存
 delete[] dynamicInt;      // 释放动态分配的整数数组内存
 delete[] dynamicString;   // 释放动态分配的字符串数组内存

 return 0;
}