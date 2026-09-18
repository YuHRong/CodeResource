// Write a C++ program to open an existing text file and display its contents on the console.

#include <iostream>
#include <fstream>
#include <string>

int main()
{
 // 打开现有的 test.txt 文件
 std::ifstream inFile{"test.txt"}; // 打开名为“test.txt”的文件进行读取

 if (inFile.is_open())
 {                    // 检查文件是否打开
  std::string line{}; // 声明一个字符串变量存储每一行文本

  while (std::getline(inFile, line))
  {                           // 循环便利文件中的每一行
   std::cout << line << '\n'; // 逐行显示
  }
  inFile.close(); // 关闭文件
 }
 else
 {
  std::cout << "Failed to open the file." << std::endl; // Display an error message if file opening failed
 }

 return 0;
}