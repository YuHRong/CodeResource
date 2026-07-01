# C++ 基本输入输出

C++ 的 I/O 发生在流中，流是字节序列。如果字节流是从设备（如键盘、磁盘驱动器、网络连接等）流向内存，这叫做`输入操作`

。如果字节流是从内存流向设备（如显示屏、打印机、磁盘驱动器、网络连接等），这叫做`输出操作`。

## I/O 库头文件

| 头文件                                                                  | 函数和描述                                                                                                       |
| ----------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| [`<iostream`>](https://www.runoob.com/cplusplus/cpp-libs-iostream.html) | 该文件定义了 cin、cout、cerr 和 clog  对象，分别对应于标准输入流、标准输出流、非缓冲标准错误流和缓冲标准错误流。 |
| [`<iomanip`>](https://www.runoob.com/cplusplus/cpp-libs-iomanip.html)   | 该文件通过所谓的参数化的流操纵器（比如 setw 和 setprecision ），来声明对执行标准化 I/O 有用的服务。              |
| [`<fstream`>](https://www.runoob.com/cplusplus/cpp-libs-fstream.html)   | 该文件为用户控制的文件处理声明服务。我们将在文件和流的相关章节讨论它的细节。                                     |

## 标准输出流（cout） 

预定义的对象 `cout` 是 `iostream` 类的一个实例。`cout` 对象"连接"到`标准输出设备`，通常是显示屏。`cout`  是与流插入运算符 `<<` 结合使用的，如下：

### 实力

```cpp
#include<iostream>

using namespace std;

int main()
{
 char str[] = "Hello World!";
 
 cout << "str 变量的值是： " << str << endl;

 return 0;
}
```

输出： `str 变量的值是： Hello World!`

C++ 编译器根据要输出变量的数据类型，选择合适的流插入运算符来显示值。`<<` 运算符被重载来输出内置类型（`整型`、`浮点型`、`double 型`、`字符串`和`指针`）的数据项。

流插入运算符 `<<` 在一个语句中可以多次使用，如上所示，`endl` 用于在行末添加一个换行符。

## 标准输入流（cin）

预定义的对象 `cin` 是 `iostream` 类的一个实例。`cin` 对象附属到`标准输入设备`，通常是键盘。`cin` 是与流提取运算符 `>>` 结合使用的，如下：

### 实力

```cpp
#include <iostream>

using namespace std;

int main()
{
 char name[50];
 cout << "What's your name?" << endl;
 cin >> name;
 cout << "welcome " << name << endl;

 return 0;
}
```

输出：  
What's your name?
Tom
welcome Tom

C++ 编译器根据要输入值的数据类型，选择合适的流提取运算符来提取值，并把它存储在给定的变量中。

流提取运算符 `>>` 在一个语句中可以多次使用，如果要求输入多个数据，可以使用如下语句：
```cpp
cin >> name >> age;  
// 等同于  
cin >> name;  
cin >> age;
```

## 标准错误流（cerr）

`cerr` 是 `iostream` 类的一个实例。`cerr` 对象附属到`标准输出设备`，通常也是显示屏，但是 `cerr` 对象是非缓冲的，且每个流插入到 `cerr` 都会立即输出。

`cerr` 也是与流插入运算符 `<<` 结合使用的，如下:

### 实力

```cpp
#include <iostream>

using namespace std;

int main()
{
 char str[] = "Unable to read....";

 cerr << "Error message : " << str << endl;

 return 0;
}
```

输出： `Error message : Unable to read....`

## 标准日志流（clog）

`clog` 是 `iostream` 类的一个实例。`clog` 对象附属到`标准输出设备`，通常也是显示屏，但是 `clog` 对象是缓冲的。这意味着每个流插入到 `clog` 都会先存储在缓冲区，直到缓冲填满或者缓冲区刷新时才会输出。
`clog` 也是与流插入运算符 `<<` 结合使用的，如下：

### 实力

```cpp
#include <iostream>

using namespace std;

int main()
{
 char str[] = "Unable to read....";
 clog << "Error message : " << str << endl;
 return 0;
}
```
输出： `Error message : Unable to read....`

这些输出在小型程序无法体现，在做大型程序时最后使用`cerr` 流来显示错误消息。其他日志消息则用 `clog` 流来输出。

------------------------------