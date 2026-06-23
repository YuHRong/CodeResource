// 使用函数实现简单计算器
#include <iostream>

using namespace std;

double add(double n1, double n2)
{
 return n1 + n2;
}

double sub(double n1, double n2)
{
 return n1 - n2;
}

double multiply(double n1, double n2)
{
 return n1 * n2;
}

double divid(double n1, double n2)
{
 if (n2 == 0)
 {
  cout << "Error: 除数不能为 0";
  return 0;
 }
 else
 {
  return n1 / n2;
 }
}

int main()
{
 char op;
 double n1, n2, result;

 cout << "输入第一个数： ";
 cin >> n1;
 cout << "输入运算符（+、-、*、/）： ";
 cin >> op;
 cout << "输入第二个数： ";
 cin >> n2;

 switch (op)
 {
 case '+':
  result = add(n1, n2);
  break;
 case '-':
  result = sub(n1, n2);
  break;
 case '*':
  result = multiply(n1, n2);
  break;
 case '/':
  result = divid(n1, n2);
  break;
 default:
  cout << "Error: 运算符错误" << endl;
  break;
 }

 cout << n1 << " " << op << " " << n2 << " = " << result << endl;

 return 0;
}