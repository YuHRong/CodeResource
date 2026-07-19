// Rewrite the character value example from the previous Try this to use a for-statement. Then modify your program to also write out a table of the integer values for uppercase letters and digits.

#include "std_lib_facilities.h"

int main()
{
 for (char c = 'A'; c <= 'Z'; c++)
  cout << c << '\t' << int(c) << '\n';

 return 0;
}