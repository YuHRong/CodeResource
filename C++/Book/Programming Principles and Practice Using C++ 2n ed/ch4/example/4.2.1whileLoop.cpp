// The character 'b' is char('a'+1), 'c' is char('a'+2), etc. Use a loop to write out a table of characters with their corresponding integer values:

#include "std_lib_facilities.h"

int main()
{
 char ch = 'a';

 while (ch <= 'z')
 {
  cout << ch << '\t' << int(ch) << '\n';
  ++ch;
 }

 return 0;
}