// Write a C++ program to count the number of words in a text file.

#include <iostream>
#include <fstream> // 包含文件流库
#include <string>  // 包含字符串库
#include <sstream> // 包含字符串流库

int main()
{
 std::ifstream inFile{"test.txt"};
 if (inFile.is_open())
 {
  std::string line{};
  int wordCounts{0};

  while (std::getline(inFile, line))
  { // 循环便利访问文件的每一行
   // 使用当前行内容创建字符串流对象
   std::stringstream ss(line);
   std::string word{}; // 声明一个字符串来存储每个单词

   while (ss >> line)
   {              // 从字符串流中提取单词
    wordCounts++; // 为提取的每个单词增加字数
   }
  }
  inFile.close();

  std::cout << "Number of words in the said file: " << wordCounts << '\n';
 }
 else
 {
  std::cout << "Failed to open the file." << '\n';
 }

 return 0;
}