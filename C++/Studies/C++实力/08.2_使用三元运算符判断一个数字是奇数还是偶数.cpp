#include<iostream>

using namespace std;

int main() 
{
 int n;

 cout << "请输入一个整数： ";
 cin >> n;

 (n % 2 == 0) ? cout << n << " 为偶数。" : cout << n << " 为奇数。";

 return 0;
}