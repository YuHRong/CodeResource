#include <iostream>

using namespace std;

int main()
{
 // 声明简单的变量
 int i;
 double d;

 // 申明引用变量
 int &r = i;
 double &s = d;

 i = 5;
 cout << "i 的值： " << i << endl;
 cout << "i 的引用值： " << r << endl;

 d = 11.7;
 cout << "d 的值： " << d << endl;
 cout << "d 的引用： " << s << endl;

 return 0;
}