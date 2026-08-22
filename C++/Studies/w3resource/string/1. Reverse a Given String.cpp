// Write a C++ program to reverse a given string.
#include <iostream>
#include <string>

using namespace std;

string string_reverse(string str)
{
 string temp_str = str; // 申明存储 str 字符串的变量
 int index_count = 0;   // 初始化索引从头开始

 for (int i = temp_str.length() - 1; i >= 0; i--)
 {                                // 以相反的顺序遍历字符串
  str[index_count] = temp_str[i]; // 反转字符并存储在原始字符串中
  index_count++;                  // 移动到下一个位置
 }

 return str; // 返回反转后的字符串
}

int main()
{
 cout << "Original string: w3resource";
 cout << "\nReverse string: " << string_reverse("w3resource");

 cout << "\n\nOriginal string: Python"; // Displaying the original string
 cout << "\nReverse string: " << string_reverse("Python"); // Displaying the reversed string

 return 0;
}