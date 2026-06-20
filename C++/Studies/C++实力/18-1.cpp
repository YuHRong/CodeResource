// 实现一个简单计算器，实现加减乘除
#include <iostream>

using namespace std;

int main()
{
 char op;
 float n1, n2;

 cout << "输入运算符（+、-、*、/） ";
 cin >> op;

 cout << "输入要计算的两个数： ";
 cin >> n1 >> n2;

 switch (op)
 {
 case '+':
  cout << n1 << " + " << n2 << " = " << n1 + n2 << endl;
  break;
 case '-':
  cout << n1 << " - " << n2 << " = " << n1 - n2 << endl;
  break;
 case '*':
  cout << n1 << " * " << n2 << " = " << n1 * n2 << endl;
  break;
 case '/':
  if (n2 == 0)
  {
   cout << "Error: 不能除以 0 ";
   break;
  }
  else
  {
   cout << n1 << " / " << n2 << " = " << n1 / n2 << endl;
   break;
  }
 default:
  cout << "Error: 运算符输入错误请输入（+、-*、/）运算符。" << endl;
  break;
 }

 return 0;
}
