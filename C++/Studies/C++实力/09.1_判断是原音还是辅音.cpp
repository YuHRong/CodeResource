#include<iostream>

using namespace std;

int main()
{
 char c;
 bool isLetter;
 int lowercase, uppercase;

 cout << "ÇëÊäÈëÒ»¸öÓ¢ÎÄ×ÖÄ¸£º ";
 cin >> c;

 isLetter = ((c >= 'a' && c <= 'z') || (c >= 'a' && c <= 'Z'));
 if (isLetter)
 {
  // Ð¡Ð´×ÖÄ¸
  lowercase = (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
  // ´óÐ´×ÖÄ¸
  uppercase = (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U');

  // Ìõ¼þÅÐ¶Ï
  if (lowercase || uppercase)
   cout << c << " ÊÇÔ­Òô" << endl;
  else
   cout << c << " ÊÇ¸¨Òô" << endl;
 }
 else
 {
  cout << "ÇëÊäÈëÓ¢ÎÄ×ÖÄ¸" << endl;
 }

 return 0;
}