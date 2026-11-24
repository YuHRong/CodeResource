// Write a C++ program to copy the contents of one text file to another.
#include <iostream>>
#include <fstream>
#include <string>

int main()
{
 // 打开输入文件
 std::ifstream inputFile("test.txt"); // 打开名为“test.txt”的文件进行读取

 // 创建或覆盖输出文件
 std::ofstream outputFile("test_copy.txt"); // 创建/覆盖名为“test_copy.txt”的文件进行写入

 if (inputFile.is_open() && outputFile.is_open())
 {                    // 检查输入和输出文件是否都已成功打开
  std::string line{}; // 声明一个字符串变量来存储每一行文本

  while (std::getline(inputFile, line))
  { // 遍历输入文件中的每一行
   // 将每一行写入输出文件
   outputFile << line << '\n'; // 用换行符将每一行写入输出文件
  }

  // 复制后关闭文件
  inputFile.close();
  outputFile.close();
  std::cout << "File copied successfully." << '\n'; // 显示成功消息
 }
 else
 {
  std::cout << "Failed to open the files." << '\n';
 }

 return 0;
}