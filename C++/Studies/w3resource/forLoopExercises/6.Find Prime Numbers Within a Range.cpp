// Write a program in C++ to find a prime number within a range.

#include <iostream> // 预处理器指令：包含输入/输出流库，用于在控制台进行输入和输出操作

using namespace std; // 使用标准命名空间，这样可以直接使用 cout、cin、endl 等，而不需要在前面加上 std::

int main() // 程序的主函数，程序的执行从这里开始
{
 int startNumber, endNumber;      // 声明两个整数变量：
                                  // startNumber：输入的范围起始数字。
                                  // endNumber：输入的范围结束数字。
 int i, prime, j, totalPrime = 0; // 声明并初始化其他整数变量：
                                  // i：外层循环变量，代表当前正在检查的数字。
                                  // prime：内层循环中用于计数当前数字 i 的因子数量。
                                  // j：内层循环变量，代表当前正在检查的可能的因子。
                                  // totalPrime：初始化为 0，用于累积计算在给定范围内找到的质数总数。

 cout << "\n\n Find prime number within a range:\n"; // 打印一个标题，说明程序的目的
 cout << "--------------------------------------\n"; // 打印一条分隔线，美化输出

 cout << "Input number for starting range: "; // 提示输入范围的起始数字
 cin >> startNumber;                          // 从标准输入（键盘）读取输入的起始数字，并存储到 startNumber 中

 cout << "Input number for ending range: "; // 提示输入范围的结束数字
 cin >> endNumber;                          // 从标准输入（键盘）读取输入的结束数字，并存储到 endNumber 中

 // 打印一个提示信息，说明接下来将输出指定范围内的质数列表。
 // 这里使用了输入的 startNumber 和 endNumber
 cout << "The prime numbers between " << startNumber << " and " << endNumber << " are: ";
 cout << endl; // 打印一个换行符，使质数列表从新行开始显示

 // 外层循环：遍历从 startNumber 到 endNumber 的所有整数
 // i 代表当前正在检查的数字，看它是否是质数
 for (i = startNumber; i <= endNumber; i++)
 {
  // 每次外层循环开始（即检查一个新的数字 i 时），
  // 将因子计数器 prime 重置为 0，以便为当前数字 i 重新计算因子数量。
  prime = 0;

  // 内层循环：查找当前数字 i 的所有正因子
  // j 从 1 开始，一直到 i。这是为了计算 i 的所有正因子（包括 1 和 i 本身）。
  for (j = 1; j <= i; j++)
  {
   // 条件判断：检查当前循环变量 j 是否能整除 i
   // 如果 i 除以 j 的余数为 0 (i % j == 0)，则 j 是 i 的一个因子
   if (i % j == 0)
   {
    prime++; // 如果 j 是 i 的因子，就将因子计数器 prime 的值加 1
   }
  }

  // 内层循环结束后，prime 变量中存储的就是数字 i 的所有正因子的总数量。
  // 根据质数的定义：一个质数只有两个正因子（1 和它本身）。
  if (prime == 2) // 如果因子总数恰好等于 2
  {
   cout << i << " "; // 那么数字 i 是一个质数，将其打印到控制台，并在后面添加一个空格作为分隔符
   totalPrime++;     // 同时，将质数总数计数器 totalPrime 的值加 1
  }
 }
 cout << endl; // 在打印完所有质数后，打印一个换行符，使后续输出从新行开始

 // 打印一个提示信息，说明接下来将输出指定范围内的质数总数。
 // 这里同样使用了输入的 startNumber 和 endNumber
 cout << "The total number of prime numbers between " << startNumber << " to " << endNumber << " is: ";
 cout << totalPrime << endl; // 打印在指定范围内找到的质数总数

 cout << endl; // 再次打印一个换行符，美化输出

 return 0; // 程序执行完毕，返回 0 表示成功，通常表示程序正常退出
}