#include <iostream>
#include <fstream>

int main()
{
 std::ifstream inFile("input.txt", std::ios::binary);
 std::ofstream outFile("output.txt", std::ios::binary);

 if (inFile.is_open() && outFile.is_open())
 {
  inFile.seekg(0, std::ios::end);       // 定位到文件末尾
  std::streampos size = inFile.tellg(); // 获取文件大小
  inFile.seekg(0, std::ios::beg);       // 定位到文件开头

  char *buffer = new char[size];
  inFile.read(buffer, size);   // 将整个文件读取到缓冲区
  outFile.write(buffer, size); // 写缓冲区到文件

  delete[] buffer;
  inFile.close();
  outFile.close();
 }
 else
 {
  std::cerr << "无法打开文件" << '\n';
 }

 return 0;
}
