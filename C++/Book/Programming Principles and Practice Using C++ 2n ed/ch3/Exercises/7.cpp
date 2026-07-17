// Do exercise 6, but with three string values. So, if the user enters the values Steinbeck, Hemingway, Fitzgerald, the output should be Fitzgerald, Hemingway, Steinbeck.

#include <iostream>
#include <string>
using namespace std;

int main()
{
 string s1, s2, s3;

 cout << "Input three string values, separated by spaces (e.g., Steinbeck Hemingway Fitzgerald):\n";
 cin >> s1 >> s2 >> s3;

 // 申明一个中间变量
 string t;

 // 交换 s1 和 s2 确保s1 小于 s2 （字典序）
 if (s1 > s2)
 {
  t = s1;
  s1 = s2;
  s2 = t;
 }

 // 交换 s2 和 s3， 确保 s2 小于 s3（字典序）
 if (s2 > s3)
 {
  t = s2;
  s2 = s3;
  s3 = t;
 }

 // 此时 s1 可能大于 s2
 // 再次交换 s1 和 s2，确保 s1 小于 s2字典序
 if (s1 > s2)
 {
  t = s1;
  s1 = s2;
  s2 = t;
 }

 // 打印排序后的字符串
 cout << s1 << ", " << s2 << ", " << s3 << endl;

 return 0;
}