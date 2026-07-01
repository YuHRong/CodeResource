// Ê¹ÓÃº¯ÊıÊµÏÖ¼òµ¥¼ÆËãÆ÷
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
  cout << "Error: ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½Îª 0";
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

 cout << "ÊäÈëµÚÒ»¸öÊı×Ö";
 cin >> n1;
 cout << "ÊäÈëÔËËã·û (+, -, *, /): ";
 cin >> op;
 cout << "ÊäÈëµÚ¶ş¸öÊı×Ö: ";
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
  cout << "Error: ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿?" << endl;
  break;
 }

 cout << n1 << " " << op << " " << n2 << " = " << result << endl;

 return 0;
}