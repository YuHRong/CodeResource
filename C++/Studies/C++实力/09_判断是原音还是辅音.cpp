#include<iostream>

using namespace std;

int main()
{
 char c;

 cout << "请输入一个英文字母： ";
 cin >> c;

 if (c == 'a' || c == 'A' || c == 'e' || c == 'E' || c == 'i' || c == 'I' || c == 'o' || c == 'O' || c == 'u' || c == 'U')
  cout << c << " 为原音" << endl;
 else
  cout << c << " 为辅音" << endl;

 return 0;
}