// Write a program in C++ to check whether a number is prime or not.

#include <iostream> // 预处理器指令：包含输入/输出流库，用于在控制台进行输入和输出操作

using namespace std; // 使用标准命名空间，这样可以直接使用 cout、cin、endl 等，而不需要在前面加上 std::

int main() // 程序的主函数，程序的执行从这里开始
{
 int n, sum = 0; // 声明两个整数变量：
                 // n：用于存储用户输入的数字，即我们要检查它是否是质数。
                 // sum：初始化为 0，用于计数数字 n 的因子（能整除 n 的数）的数量。

 cout << "\n\n Check whether a number is prime or not:\n"; // 打印一个标题，说明程序的目的
 cout << "--------------------------------------------\n"; // 打印一条分隔线，美化输出

 cout << "Input a number to check prime or not: " << endl; // 提示用户输入一个数字
 cin >> n;                                                 // 从标准输入（键盘）读取用户输入的整数，并将其存储到变量 n 中

 // for 循环：遍历从 1 到 n 的所有整数
 // 循环的目的是找出数字 n 有多少个正因子
 for (int i = 1; i <= n; i++)
 {
  // 条件判断：检查当前循环变量 i 是否是 n 的一个因子
  // 如果 n 除以 i 的余数为 0 (n % i == 0)，则 i 是 n 的一个因子
  if (n % i == 0)
  {
   sum++; // 如果 i 是 n 的因子，就将 sum 的值加 1（即因子计数器加 1）
  }
 }

 // 循环结束后，sum 变量中存储的就是数字 n 的所有正因子的总数量。
 // 根据质数的定义：一个质数（素数）是一个大于 1 的自然数，它只有两个正因子（1 和它本身）。
 if (sum == 2) // 如果因子总数恰好等于 2
 {
  cout << " The entered number is a prime number. \n"; // 那么数字 n 是一个质数，打印相应信息
 }
 else // 如果因子总数不等于 2（可能是 1，或者大于 2）
 {
  cout << " The number you entered is not a prime number. \n"; // 那么数字 n 不是一个质数，打印相应信息
 }

 return 0; // 程序执行完毕，返回 0 表示成功，通常表示程序正常退出
}