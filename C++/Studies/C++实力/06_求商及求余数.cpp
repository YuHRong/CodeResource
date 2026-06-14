// 获取用户输入的两个数并求商和余数打印在屏幕上
#include<iostream>

using namespace std;

int main() {
 int divisor, dividend, quotient, remaimder;

 cout << "输入被除数： ";
 cin >> dividend;
 cout << "输入除数： ";
 cin >> divisor;

 quotient = dividend / divisor;
 remaimder = dividend % divisor;

 cout << endl << dividend << " 除以 " << divisor << " 等于 " << quotient << "\n余 " << remaimder << endl;

 return 0;
}