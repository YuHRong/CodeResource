# 文件和流

## fstream
使用文件流时，需要包含头文件`<fstream>`和`<iostream>`。

`fstream`库的三个主要数据类型:
- `ofstream`：输出文件流，用于创建文件并向文件写入信息。
- `ifstream`：输入文件流，用于从文件读取信息。
- `fstream`文件流，同时具有`ofstream`和`ifstream`功能，支持读写操作。

```cpp
#include<fstream>
#include<iostream>
```

## 打开文件
进行文件操作时，需要先打开文件。`ofstream`和`fstream`用于写操作，`ifstream`用于读操作，文件的打开模式可以通过`open`函数指定。

### 语法
```cpp
void open(const char *filename, ios::openmode mode);
```

### 常用的打开模式
- `ios::app`：追加模式。所有写入都追加到文件末尾。
- `ios::ate`：文件打开后定位到文件末尾。
- `ios::in`：打开文件用于读取。
- `ios::out`打开文件用于写入。
- `ios::trunc`：如果文件已经存在，则在打开文件之前清空其内容。

```cpp
ofstream outfile;
outfile.open("file.dat", ios::out | ios::trunc);

ifstream infile;
infile.open("file.dat", ios::out);
```

## 关闭文件
使用`close`方法关闭文件。

```cpp
outfile.close();
infile.close();
```

## 写入文件
使用流插入符`<<`可以像文件写入信息，与`cout`的用法类似。

```cpp
ofstream outfile("file.dat");
outfile << "Hello, world!" << '\n';
outfile.close();
```

## 读取文件
使用流提取运算符`>>`可以从文件提取信息，与`cin`的用法类似。

```cpp
ifstream infile("file.dat");
string data;
infile >> data;
cout << data << '\n';>>>>
infile.close();
```

## 读取写入文件示例
```cpp
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
```

## 文件的指针操作
可以使用以下方法操作指针
- `seek`设置输入位置。
- `seekp`设置输出位置。
- `tellg`获取输入位置
- `tellp`获取输出位置。

 `istream`和 `ostream`提供了用于重新定位文件位置指针的成员函数： `seekg`（"seek get"）和 `seekp`（"seek put"）。

###  定位文件指针示例 1

 ```cpp
ifstream fileObject("file.dat");

// 定位到文件的第 n 个字节（假设从文件开头开始）
fileObject.seekg(n, ios::beg);

// 从当前位置向后移n个字节
fileObject.seekg(n, ios::cur);

// 从文件末尾往回移n个字节
fileObject.seekg(n, ios::end);

// 定位到文件末尾
fileObject.seekg(0, ios::end);
```

### 定位文件指针示例 2
```cpp
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
```

## 错误处理
可以使用以下方法检查错误状态
- `good()`无错误。
- `eof()`到达文件末尾。
- `fail()`非致命i/o错误。
- `bad()`致命i/o错误。

```cpp
ifstream inFile("input.txt");

if(inFile.is)_open())
{
// 检查文件流的状态
if(inFile.good()){
 // 继续处理文件
}
else if(inFile.eof()){
cerr << "到达文件末尾" << '\n';>>
}
else if(inFile.fail()){
 cerr << "非致命 i/o 错误" << '\n';
}
else if(inFile.bad()){
 cerr << "致命 i/o 错误" << '\n';
}

inFile.close();
}
else
{
 cerr << "无法打开文件" << '\n';
}
```

## 综合示例
```cpp
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
```