// 不使用中间变量交换两个数的值
#include<iostream>

using namespace std;

int main() {
 int i, j;

 cout << "输入两个整数： ";
 cin >> i >> j;

 cout << "你输入的整数为： " << i << " " << j << endl;

 i = i + j;
 j = i - j;
 i = i - j;

 cout << "两个数交换后： " << i << " " << j << endl;

 return 0;
}