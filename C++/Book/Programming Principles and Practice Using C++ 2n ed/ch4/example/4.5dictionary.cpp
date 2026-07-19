#include "std_lib_facilities.h"

int main()
{
 vector<string> words;

 for (string temp; cin >> temp;) // 读取空格分隔的单词
 {
  words.push_back(temp); // 放入 vector

  cout << "Number of words: " << words.size() << '\n';

  sort(words); // 对 words 进行排序

  for (int i = 0; i < words.size(); ++i)
   if (i == 0 || words[i - 1] != words[i]) // 这是一个新词吗
    cout << words[i] << "\n";
 }

 return 0;
}