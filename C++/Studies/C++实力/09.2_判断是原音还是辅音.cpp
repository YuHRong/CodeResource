#include<iostream>

using namespace std;

bool isVowel(char letter) 
{
 // 将字母转换为小写
 letter = tolower(letter);

 // 判断字母是否为元音
 if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
 {
  return true;
 }
 else
 {
  return false;
 }
}

int main()
{
 char letter;

 cout << "请输入一个字母： ";
 cin >> letter;

 if (isVowel(letter))
 {
  cout << letter << " 为元音字母。" << endl;
 }
 else
 {
  cout << letter << " 为辅音字母。" << endl;
 }

 return 0;
}