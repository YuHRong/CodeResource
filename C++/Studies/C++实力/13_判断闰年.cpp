#include<iostream>

using namespace std;

int main()
{
 int year;

 cout << "请输入年份： ";
 cin >> year;

 if (year % 2 == 0)
 {
  if (year % 100 == 0)
  {
   if (year % 400 == 0)
   {
    cout << year << " 年是闰年" << endl;
   }
   else
   {
    cout << year << " 年不是闰年" << endl;
   }
  }
  else
  {
  cout << year << " 年是闰年" << endl;
  }
 }
 else
 {
  cout << year << " 年不是闰年" << endl;
 }

 return 0;
}