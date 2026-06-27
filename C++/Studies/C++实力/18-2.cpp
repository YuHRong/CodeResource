// ʹ�ú���ʵ�ּ򵥼�����
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
  cout << "Error: ��������Ϊ 0";
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

 cout << "�����һ������ ";
 cin >> n1;
 cout << "�����������+��-��*��/���� ";
 cin >> op;
 cout << "����ڶ������� ";
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
  cout << "Error: ���������" << endl;
  break;
 }

 cout << n1 << " " << op << " " << n2 << " = " << result << endl;

 return 0;
}