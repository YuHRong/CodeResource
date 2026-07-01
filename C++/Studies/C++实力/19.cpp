// 猴子吃桃
// 一只小猴子一天摘了许多桃子，第一天吃了一半，然后忍不住又吃了一个；第二天又吃了一半，再加上一个；后面每天都是这样吃。到第10天的时候，小猴子发现只有一个桃子了。问小猴子第一天共摘了多少个桃子。

#include <iostream>

using namespace std;

int main()
{
 int peaches = 1; // 第10天剩下的桃子数
 int inputDay;

 cout << "请输入吃了多少天桃子； ： " << endl;
 cin >> inputDay;

 if (inputDay < 1)
 {
  cout << "输入的天数不合法，请输入大于等于1的整数" << endl;
  return 1;
 }

 for (int day = inputDay - 1; day > 0; day--)
 {
  peaches = (peaches + 1) * 2; // 反推前一天的桃子数
 }
 cout << "第一天共摘了" << peaches << "个桃子" << endl;

 return 0;
}