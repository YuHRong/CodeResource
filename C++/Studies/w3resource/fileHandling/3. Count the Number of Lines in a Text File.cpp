// Write a C++ program to count the number of lines in a text file.

#include <iostream>
#include <fstream>
#include <string>

int main()
{
 // 打开现有文件
 std::ifstream inFile{"test.txt"};
 if (inFile.is_open())
 {
  std::string line{};
  int count{0};

  while (std::getline(inFile, line))
  { // 循环便利文件的每一行，
   count++;
  }

  inFile.close();
  std::cout << "Number of lines in the file: " << count << '\n';
 }
 else
 {
  std::cout << "Failed to open the file." << std::endl; // Display an error message if file opening failed
 }

 return 0;
}