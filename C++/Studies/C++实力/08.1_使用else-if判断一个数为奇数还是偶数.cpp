#include<iostream>

using namespace std;

int main() {
 int n;

 cout << "请输入一个整数： ";
 cin >> n;

 if (n % 2 == 0)
  cout << endl << n << " 为偶数" << endl;
 else
  cout << endl << n << " 为奇数" << endl;


}