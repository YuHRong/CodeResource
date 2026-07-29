// Write a C++ program to check whether numbers in a vector can be rearranged so that each number appears exactly once in a consecutive list of numbers. Return true otherwise false.

#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

// 函数申明
bool isRearr(vector<int> num);

int main()
{
 vector<int> num = {1, 2 ,5, 7, 4, 3, 6}; // Test vector with non-consecutive numbers
 // vector<int> num = {1, 2, 5, 0, 3, 6, 7}; // Test vector with consecutive numbers

 for (int x : num)
 {
  cout << x << " ";
 }
 cout << "\nCheck consecutive numbers in the said vector! \n";

 cout << isRearr(num);

 return 0;
}

bool isRearr(vector<int> num)
{
 // 按升序对 vector 的元素进行排序
 sort(num.begin(), num.end());

 // 便利 vector 元素，检查是否连续排列
 for (int i = 0; i < num.size() - 1; i++)
 {
  if (num[i + 1] != (num[i] + 1))
   return false; // 如果元素不连续，则返回false
 }

 // 如果所有元素都是连续的，则返回true
 return true;
}