#include<iostream>

using namespace std;

int main()
{
 int n, sum = 0;

 cout << "输入一个整数： ";
 cin >> n;

 for (int i = 1; i <= n; i++)
 {
  sum += i;
 }
 cout << "1 到 " << n << " 的和是： " << sum << endl;

 return 0;
}