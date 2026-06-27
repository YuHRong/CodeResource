# C++ 数字

## C++ 数字类型

### 实力

```c++

#include <iostream>
using namespace std;

int main()
{
 // 数字定义
 short s;
 int i;
 long l;
 float f;
 double d;

 // 数字赋值
 s = 10;
 i = 1000;
 l = 1000000;
 f = 230.47;
 d = 30949.374;

 // 数字输出
 cout << "short  s :" << s << endl;
 cout << "int    i :" << i << endl;
 cout << "long   l :" << l << endl;
 cout << "float  f :" << f << endl;
 cout << "double d :" << d << endl;

 return 0;
}
```

## C++ 数学函数

C++ 内置了丰富的数学函数，可对各种数字进行运算。下表列出了 C++ 中一些有用的内置的数学函数。

为了利用这些函数，您需要引用数学头文件 <cmath>。

| 序号 | 函数名称                      | 说明                                                                                                     |
| ---- | ----------------------------- | -------------------------------------------------------------------------------------------------------- |
| 1    | double cos(double);           | 该函数返回弧度角（double 型）的余弦。                                                                    |
| 2    | double sin(double);           | 该函数返回弧度角（double 型）的正弦                                                                      |
| 3    | double tan(double);           | 该函数返回弧度角（double 型）的正切。                                                                    |
| 4    | double log(double);           | 该函数返回参数的自然对数。                                                                               |
| 5    | double pow(double, double);   | 假设第一个参数为 x，第二个参数为 y，则该函数返回 x 的 y 次方。                                           |
| 6    | double hypot(double, double); | 该函数返回两个参数的平方总和的平方根，也就是说，参数为一个直角三角形的两个直角边，函数会返回斜边的长度。 |
| 7    | double sqrt(double);          | 该函数返回参数的平方根。                                                                                 |
| 8    | int abs(int);                 | 该函数返回整数的绝对值。                                                                                 |
| 9    | double fabs(double);          | 该函数返回任意一个浮点数的绝对值。                                                                       |
| 10   | double floor(double);         | 该函数返回一个小于或等于传入参数的最大整数。                                                             |

### 实力

```c++
#include <iostream>
#include <cmath>

using namespace std;

int main()
{
 // 数字定义
 short s = 10;
 int i = -1000;
 long l = 100000;
 float f = 230.47;
 double d = 200.374;

 // 数学运算
 cout << "sin(d) :" << sin(d) << endl;
 cout << "abs(i)  :" << abs(i) << endl;
 cout << "floor(d) :" << floor(d) << endl;
 cout << "sqrt(f) :" << sqrt(f) << endl;
 cout << "pow( d, 2) :" << pow(d, 2) << endl;

 return 0;
}
```

## 随机数

生成随机数的函数有 `rand()`函数，该函数返回一个伪随机数。

生成随机数前需先调用 `srand()`函数。

### 实力

生成随机数的简单实例。实例中使用 `time()`  函数来获取系统时间的秒数，通过调用 `rand()` 函数来生成随机数：

```c++
#include <iostream>
#include <ctime>
#include <cstdlib>

using namespace std;

int main()
{
 int i, j;

 // 设置种子
 srand((unsigned)time(NULL));

 // 生成 10个随机数
 for (i = 0; i < 10; i++)
 {
  // 生成实际的随机数
  j = rand();

  cout << "随机数： " << j << endl;
 }

 return 0;
}
```

## 常数

在 C++ 中，数学常数（如 π、e、黄金比例等）是许多算法和应用中不可或缺的部分，虽然早期版本的 C++ 中没有直接提供这些常数，但从 C++20 开始，标准库引入了几个常用的数学常数，并提供了更高效和统一的方式来访问它们。

更多内容可参考[C++ 标准库 <numbers>](https://www.runoob.com/cplusplus/cpp-libs-numbers.html)

### PI 

常量`std::numbers::pi`

类型：`std::float32_t `（32位浮动）`、`std::float64_t` （64位浮动）`

#### 实力

```c++
#include <cmath>
#include <iostream>
int main() {
    std::cout << "pi: " << std::numbers::pi << std::endl;
}
```

### 自然对数的底数 e (Euler's Number)

常量：`std::numbers::e`
类型：`std::float32_t`、`std::float64_t`

```c++
std::cout << "e: " << std::numbers::e << std::endl;
```

### 黄金比例 φ (Golden Ratio)

常量：`std::numbers::phi`
类型：`std::float32_t`、`std::float64_t`

```c++
std::cout << "phi: " << std::numbers::phi << std::endl;
``

#### 实力

```c++
#include <iostream>
#include <cmath>
#include <numbers>

using namespace std;

int main()
{
 std::cout << "pi: " << std::numbers::pi << std::endl;
 std::cout << "e: " << std::numbers::e << std::endl;
 std::cout << "phi: " << std::numbers::phi << std::endl;

 return 0;
}
```

