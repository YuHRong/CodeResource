// 获取用户输入的两个数字，并相加之后打印到屏幕

#include<iostream>

using namespace std;
int main() {
 int n1, n2, sum;

 cout << "输入两个整数： ";
 cin >> n1 >> n2;

 // 相加
 sum = n1 + n2;
 cout << n1 << " + " << n2 << " = " << sum << endl;

 return 0;
}