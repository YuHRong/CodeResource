#include<iostream>

using namespace std;

int main() {
 int i, j, n;

 cout << "输入两个整数： ";
 cin >> i >> j;

 n = i;
 i = j;
 j = n;

 cout << "两个数交换后等于： " << i << " " << j << endl;

 return 0;
}