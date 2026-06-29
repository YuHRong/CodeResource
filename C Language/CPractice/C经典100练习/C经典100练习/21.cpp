#include <iostream>
using namespace std;

int main()
{
 auto sum = (10 <=> 20) > 0;

 cout << "C++20特性： " << sum << endl;
 cout << "正在运行的版本： " << __cplusplus << endl;

 return 0;
}