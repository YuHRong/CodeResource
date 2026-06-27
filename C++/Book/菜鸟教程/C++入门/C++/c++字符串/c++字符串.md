# c++字符串

## 字符串函数

字符串的一些常用函数

| 序号 | 函数            | 说明                                                                                                                                           |
| ---- | --------------- | ---------------------------------------------------------------------------------------------------------------------------------------------- |
| 1    | strcpy(s1, s2); | 复制字符串 s2 到字符串 s1。                                                                                                                    |
| 2    | strcat(s1, s2); | 连接字符串 s2 到字符串 s1 的末尾。连接字符串也可以用 + 号，例如:`string str1 = "runoob";` `string str2 = "google";` string str = str1 + str2;` |
| 3    | strlen(s1);     | 返回字符串 s1 的长度。                                                                                                                         |
| 4    | strcmp(s1, s2); | 如果 `s1` 和 `s2` 是相同的，则返回 `0`。如果 `s1`<`s2` 则返回`值小于 0`。如果 `s1`>`s2` 则返回`值大于 0`                                       |
| 5    | strchr(s1, ch); | 返回一个指针，指向字符串 s1 中字符 ch 的第一次出现的位置。                                                                                     |
| 6    | strstr(s1, s2); | 返回一个指针，指向字符串 s1 中字符串 s2 的第一次出现的位置。                                                                                   |

### 实力

```c++
#include <iostream>
#include <cstring>

using namespace std;

int main()
{
 char str1[13] = "runoob";
 char str2[13] = "google";
 char str3[13];
 int len;

 // 复制 str1 到 str3
 strcpy(str3, str1);
 cout << "strcpy (str3, str1) : " << str3 << endl;

 // 连接 str1 和 str2
 strcat(str1, str2);
 cout << "strcat (str1, str2) : " << str1 << endl;

 // 连接后，str1 的总长度
 len = strlen(str1);
 cout << "strlen (str1) : " << len << endl;

 return 0;
}
```

## String 类

### 实力


```c++
#include <iostream>
#include <string>

using namespace std;

int main()
{
 string str1 = "runoob";
 string str2 = "google";
 string str3;
 int len;

 // 复制 str1 到 str3
 str3 = str1;
 cout << "str3 : " << str3 << endl;

 // 连接 str1 和 str2
 str3 = str1 + str2;
 cout << "str1 + str2 : " << str3 << endl;

 // 连接后，str3 的总长度
 len = str3.size();
 cout << "str3.size() :  " << len << endl;

 return 0;
}
```

## 指针详解

在 C++ 中，有很多指针相关的概念，这些概念都很简单，但是都很重要。下面列出了 C++ 程序员必须清楚的一些与指针相关的重要概念：

| 概念                                                                                          | 概念 描述                                                     |
| --------------------------------------------------------------------------------------------- | ------------------------------------------------------------- |
| [C++ Null 指针](https://www.runoob.com/cplusplus/cpp-null-pointers.html)                      | C++ 支持空指针。NULL 指针是一个定义在标准库中的值为零的常量。 |
| [C++ 指针的算术运算](https://www.runoob.com/cplusplus/cpp-pointer-arithmetic.html)            | 可以对指针进行四种算术运算：++、--、+、-                      |
| [C++ 指针 vs 数组](https://www.runoob.com/cplusplus/cpp-pointers-vs-arrays.html)              | 指针和数组之间有着密切的关系。                                |
| [C++ 指针数组](https://www.runoob.com/cplusplus/cpp-array-of-pointers.html)                   | 可以定义用来存储指针的数组。                                  |
| [C++ 指向指针的指针](https://www.runoob.com/cplusplus/cpp-pointer-to-pointer.html)            | C++ 允许指向指针的指针。                                      |
| [C++ 传递指针给函数](https://www.runoob.com/cplusplus/cpp-pointer-to-pointer.html)            | 通过引用或地址传递参数，使传递的参数在调用函数中被改变。      |
| [C++ 从函数返回指针](https://www.runoob.com/cplusplus/cpp-return-pointer-from-functions.html) | C++ 允许函数返回指针到局部变量、静态变量和动态内存分配。      |

------------------------------------------------------------
