// calculate and print a table of squares 0¨C99

#include "std_lib_facilities.h"

int square(int x);

int main()
{
 int i = 0; // start from 0

 while (i < 100)
 {
  cout << i << '\t' << square(i) << '\n';
  ++i; // µÝÔö i£¬¼° i + 1
 }

 return 0;
}

int square(int x)
{
 return x * x;
}