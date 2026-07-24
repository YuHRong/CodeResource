// Write a program in C++ to find the factorial of a number.

#include <iostream> // 预处理器指令：包含输入/输出流库，用于在控制台进行输入和输出操作

using namespace std; // 使用标准命名空间，这样可以直接使用 cout、cin、endl 等，而不需要在前面加上 std::

int main() // 程序的主函数，程序的执行从这里开始
{
 int n;           // 声明一个整数变量 n，用于存储用户输入的数字，即我们要计算其阶乘的数。
 long long f = 1; // 声明一个 long long 类型的变量 f，用于存储计算出的阶乘结果。
                  // 初始化为 1，因为 0! = 1，并且这是乘法累积的起始值。
                  // 使用 long long 类型是为了能够存储更大的阶乘结果，避免 int 溢出。

 cout << "\n\n Find the factorial of a number:\n"; // 打印一个标题，说明程序的目的
 cout << "------------------------------------\n"; // 打印一条分隔线，美化输出

 cout << "Input a number to find the factorial: "; // 提示用户输入一个数字
 cin >> n;                                         // 从标准输入（键盘）读取用户输入的整数，并将其存储到变量 n 中

 // for 循环：从 1 开始，一直迭代到用户输入的数字 n
 // 循环的目的是将 f 乘以从 1 到 n 的所有整数，从而计算阶乘
 for (int i = 1; i <= n; i++)
 {
  f *= i; // 核心计算：将当前的 f 值乘以循环变量 i，并将结果重新赋值给 f。
          // 这是一个累积乘法的过程：f = f * i;
 }

 cout << "The factorial of the given number is: "; // 打印一个提示信息，说明接下来将输出阶乘结果
 cout << f << endl;                                // 打印计算出的阶乘结果 f，并在末尾添加一个换行符

 return 0; // 程序执行完毕，返回 0 表示成功，通常表示程序正常退出
}