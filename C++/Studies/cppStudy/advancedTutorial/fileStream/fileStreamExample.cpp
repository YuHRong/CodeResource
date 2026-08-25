// 此文件是一个综合示例，演示了文件的读取、写入、文件指针操作和错误处理。

#include <iostream>
#include <fstream>
#include <string>

int main()
{
 // 打开输入文件
 std::ifstream inFile("input.txt");
 if (!inFile)
 {
  std::cerr << "无法打开输入文件" << '\n';
  return 1;
 }

 // 打开输出文件
 std::ofstream outFile("output.txt");
 if (!outFile)
 {
  std::cerr << "无法打开输出文件" << '\n';
  return 1;
 }

 std::string line;
 while (std::getline(inFile, line))
 {
  // 逐行读取并写入输出文件
  outFile << line << '\n';
 }

 // 检查读取是否成功
 if (inFile.eof())
 {
  std::cout << "文件读取完成" << '\n';
 }
 else if (inFile.fail())
 {
  std::cerr << "文件读取失败" << '\n';
 }
 else
 {
  std::cerr << "未知错误" << '\n';
 }

 inFile.close();
 outFile.close();

 return 0;
}