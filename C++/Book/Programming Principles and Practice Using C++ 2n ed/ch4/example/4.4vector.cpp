#include "std_lib_facilities.h"

int main()
{
 vector<int> v = {5, 7, 9, 6, 4, 8};

 for (int i = 0; i < v.size(); i++)
  cout << v[i] << '\n';

 for (int x : v)
  cout << x << '\n';
 return 0;
}