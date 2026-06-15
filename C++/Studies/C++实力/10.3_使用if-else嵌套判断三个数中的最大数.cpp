#include<iostream>

using namespace std;

int main()
{
 float n1, n2, n3;

 cout << "请输入三个数： ";
 cin >> n1 >> n2 >> n3;

 if (n1 >= n2)
 {
  if (n1 >= n3)
   cout << "最大数是： " << n1 << endl;
  else
   cout << "最大数是： " << n3 << endl;
 }
 else
 {
  if (n2 >= n3)
   cout << "最大数是： " << n2 << endl;
  else
   cout << "最大数是： " << n3 << endl;
 }

 return 0;
}