// Write a C++ program to create a new text file and write some text into it.

#include <iostream>
#include <fstream>

int main()
{
 // 创建一个名为 test.txt 的文件
 std::ofstream outputFile{"test.txt"}; // 打开创建一个名为 test.txt 的文件进行写入
 // 检查文件是否成功打开
 if (outputFile.is_open())
 {
  // 在文件中写入文本
  outputFile << "C++ is a high-level, general-purpose programming language created by Danish computer scientist Bjarne Stroustrup. \n";                       // Write a line of text to the file
  outputFile << "First released in 1985 as an extension of the C programming language, it has since expanded significantly over time. \n";                    // Write a line of text to the file
  outputFile << "Modern C++ currently has object-oriented, generic, and functional features, in addition to facilities for low-level memory manipulation.\n"; // Write a line of text to the file
  outputFile << "It is almost always implemented in a compiled language.\n";                                                                                  // Write a line of text to the file
  outputFile << "Many vendors provide C++ compilers, including the Free Software Foundation, LLVM, Microsoft, Intel, Embarcadero, Oracle, and IBM.";          // Write a line of text to the file

  // 关闭文件
  outputFile.close();
  std::cout << "Text has been written to the file." << std::endl; // Display a success message
 }
 else
 {
  std::cout << "Failed to create the file." << std::endl; // Display an error message if file creation failed
 }

 return 0;
}