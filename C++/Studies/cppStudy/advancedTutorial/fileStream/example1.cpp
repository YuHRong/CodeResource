#include <fstream>
#include <iostream>

int main()
{
 char data[100];

 // 以写模式打开文件
 std::ofstream outfile;
 outfile.open("afile.dat");

 std::cout << "写入文件" << '\n';
 std::cout << "输入姓名：";
 std::cin.getline(data, 100);
 outfile << data << '\n';

 std::cout << "输入你的年龄";
 std::cin >> data;
 std::cin.ignore();
 outfile << data << '\n';

 outfile.close();

 // 以读模式打开文件
 std::ifstream infile;
 infile.open("afile.dat");

 std::cout << "正在读取文件" << '\n';
 infile >> data;
 std::cout << data << '\n';

 infile >> data;
 std::cout << data << '\n';

 infile.close();

 return 0;
}