// Write a C++ program to print a mystery series from 1 to 50.

#include <iostream>

using namespace std;
int main()
{
 cout << "Print a mystery series:\n";
 cout << "-------------------------\n";

 cout << "The series are:\n";

 int n = 1; // 初始化变量 n 为 1

 while (true)
 {
  ++n; // 每次迭代之前 n 递增 1

  // 检查 n 是否能被 3 整除
  if ((n % 3) == 0)
   continue; // 如果能被3整除跳过此项

  if (n == 50)
   break; // 如果 n 等于 50跳出循环

  // 检查 n 是否为偶数
  if ((n % 2) == 0)
  {
   // 如果 n 是偶数， + 3
   n += 3;
  }
  else
  {
   // 如果 n 是奇数，减 3
   n -= 3;
  }

  cout << n << " ";
 }
 cout << '\n';

 return 0;
}