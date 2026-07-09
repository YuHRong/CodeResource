#include "std_lib_facilities.h"

int main()
{
 int number_of_words = 0;
 string previous = " "; // 前一个单词，初始化为空
 string current;        // 当前单词

 while (cin >> current)
 {                         // 连续读取单词
  ++number_of_words;       // increase word count
  if (previous == current) // 检查单词是否与最后一个相同
   cout << "word number " << number_of_words
        << " repeated: " << current << '\n';
  previous = current;
 }

 return 0;
}