// Write a program in C++ to find the perfect numbers between 1 and 500.

#include <iostream> // 包含输入输出流库，用于在控制台打印信息

using namespace std; // 使用标准命名空间，这样可以直接使用 cout、endl 等，而不需要写 std::

int main() // 程序的主函数，程序的执行从这里开始
{
 int i, j; // 声明两个整数变量：i 用于外层循环，j 用于内层循环

 cout << "\n\n Find the perfect numbers between 1 and 500:\n"; // Display a message indicating the purpose
 cout << "------------------------------------------------\n"; // Display a separator line

 cout << "\n The perfect numbers between 1 to 500 are: \n"; // Display a message indicating the list of perfect numbers

 // 外层循环：遍历从 1 到 500 的所有数字
 // i 代表当前正在检查的数字，看它是否是完美数
 for (i = 1; i <= 500; i++)
 {
  // 声明并初始化 sum 变量。
  // sum 用于存储当前数字 i 的所有真因子之和。
  // 每次外层循环开始（即检查一个新的数字 i 时），sum 都会被重置为 0。
  int sum = 0;

  // 内层循环：查找当前数字 i 的所有真因子
  // j 从 1 开始，一直到 i/2。这是因为一个数的真因子最大不会超过它本身的一半（除了1）。
  for (j = 1; j <= i / 2; j++)
  {
   // 判断 j 是否是 i 的一个因子
   // 如果 i 除以 j 的余数为 0，则 j 是 i 的因子
   if (i % j == 0)
   {
    // 如果 j 是 i 的因子，就将其累加到 sum 中
    sum += j;
   }
  }

  // 内层循环结束后，sum 变量中存储的就是数字 i 的所有真因子之和。
  // 根据完美数的定义进行判断：如果真因子之和等于数字本身，那么它就是完美数。
  if (sum == i)
  {
   // 如果 i 是完美数，就将其打印到控制台。
   cout << i << endl;
  }
 }
 cout << endl;

 return 0; // 程序执行完毕，返回 0 表示成功
}