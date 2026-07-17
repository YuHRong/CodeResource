/*
Write a program that prompts the user to enter some number of
pennies (1-cent coins),
nickels (5-cent coins),
dimes  (10-cent coins),
quarters(25-cent coins),
half dollars(50-cent coins),
and
one-dollar coins (100-cent coins).
Query the user separately for the number of each size coin, e.g., “How many pennies do you have?” Then your program should print out something like this:
You have 23 pennies.
You have 17 nickels.
You have 14 dimes.
You have 7 quarters.
You have 3 half dollars.
The value of all of your coins is 573 cents.
Make some improvements: if only one of a coin is reported, make the output grammatically correct, e.g., 14 dimes and 1 dime (not 1 dimes). Also, report the sum in
dollars and cents, i.e., $5.73 instead of 573 cents.
*/

#include <iostream>
#include <limits>  // For std::numeric_limits
#include <iomanip> // For std::setw, std::setfill

int main()
{
 // 声明用于存储各种硬币数量的整数变量
 int pennies, nickels, dimes, quarters, half_dollars, one_dollars;
 // 声明并初始化总美分变量
 int total_cents = 0;

 // 提示用户输入便士数量
 std::cout << "How much pennies do you have?";
 // 读取便士数量
 std::cin >> pennies;

 // 检查便士输入的有效性
 if (std::cin.fail())
 {
  std::cout << "Input error! Please enter a valid number." << std::endl;
  // 清除输入流的错误标志
  std::cin.clear();
  // 忽略输入缓冲区中剩余的无效字符
  std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');

  // 程序异常退出
  return 1;
 }
 // 检查便士数量是否为负数
 if (pennies < 0)
 {
  std::cout << "Error: Number of pennies cannot be negative." << std::endl;

  // 程序异常退出
  return 1;
 }

 // 提示用户输入镍币数量
 std::cout << "How much nickels do you have?";
 // 读取镍币数量
 std::cin >> nickels;

 // 检查镍币输入的有效性
 if (std::cin.fail())
 {
  std::cout << "Input error! Please enter a valid number." << std::endl;
  // 清除输入流的错误标志
  std::cin.clear();
  // 忽略输入缓冲区中剩余的无效字符
  std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');

  // 程序异常退出
  return 1;
 }
 // 检查镍币数量是否为负数
 if (nickels < 0)
 {
  std::cout << "Error: number of nickels cannot be negative." << std::endl;

  // 程序异常退出
  return 1;
 }

 // 提示用户输入10美分硬币数量
 std::cout << "How much dimes do you have?";
 // 读取10美分硬币数量
 std::cin >> dimes;

 // 检查10美分硬币输入的有效性
 if (std::cin.fail())
 {
  std::cout << "Input error! Please enter a valid number." << std::endl;
  // 清除输入流的错误标志
  std::cin.clear();
  // 忽略输入缓冲区中剩余的无效字符
  std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');

  // 程序异常退出
  return 1;
 }
 // 检查10美分硬币数量是否为负数
 if (dimes < 0)
 {
  std::cout << "Error: Number of dimes cannot be negative." << std::endl;
  // 程序异常退出

  return 1;
 }

 // 提示用户输入25美分硬币数量
 std::cout << "How much quarters do you have?";
 // 读取25美分硬币数量
 std::cin >> quarters;

 // 检查25美分硬币输入的有效性
 if (std::cin.fail())
 {
  std::cout << "Input error! Please enter a valid number." << std::endl;
  // 清除输入流的错误标志
  std::cin.clear();
  // 忽略输入缓冲区中剩余的无效字符
  std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');

  // 程序异常退出
  return 1;
 }
 // 检查25美分硬币数量是否为负数
 if (quarters < 0)
 {
  std::cout << "Error: Number of quarters cannot be negative." << std::endl;

  // 程序异常退出
  return 1;
 }

 // 提示用户输入半美元硬币数量
 std::cout << "How much half dollars do you have?";
 // 读取半美元硬币数量
 std::cin >> half_dollars;

 // 检查半美元硬币输入的有效性
 if (std::cin.fail())
 {
  std::cout << "Input error! Please enter a valid number." << std::endl;
  // 清除输入流的错误标志
  std::cin.clear();
  // 忽略输入缓冲区中剩余的无效字符
  std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');

  // 程序异常退出
  return 1;
 }
 // 检查半美元硬币数量是否为负数
 if (half_dollars < 0)
 {
  std::cout << "Error: Number of half dollars cannot be negative." << std::endl;

  // 程序异常退出
  return 1;
 }

 // 提示用户输入一美元硬币数量
 std::cout << "How much dollars do you have?";
 // 读取一美元硬币数量
 std::cin >> one_dollars;

 // 检查一美元硬币输入的有效性
 if (std::cin.fail())
 {
  std::cout << "Input error! Please enter a valid number." << std::endl;
  // 清除输入流的错误标志
  std::cin.clear();
  // 忽略输入缓冲区中剩余的无效字符
  std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');

  // 程序异常退出
  return 1;
 }
 // 检查一美元硬币数量是否为负数
 if (one_dollars < 0)
 {
  std::cout << "Error: Number of one-dollars cannot be negative." << std::endl;

  // 程序异常退出
  return 1;
 }

 // 根据便士数量打印单数或复数形式
 if (pennies == 1)
 {
  std::cout << "You have " << pennies << " penny." << std::endl;
 }
 else
 {
  std::cout << "You have " << pennies << " pennies." << std::endl;
 }

 // 根据镍币数量打印单数或复数形式
 if (nickels == 1)
 {
  std::cout << "You have " << nickels << " nickel." << std::endl;
 }
 else
 {
  std::cout << "You have " << nickels << " nickels." << std::endl;
 }

 // 根据10美分硬币数量打印单数或复数形式
 if (dimes == 1)
 {
  std::cout << "You have " << dimes << " dime." << std::endl;
 }
 else
 {
  std::cout << "You have " << dimes << " dimes." << std::endl;
 }

 // 根据25美分硬币数量打印单数或复数形式
 if (quarters == 1)
 {
  std::cout << "You have " << quarters << " quarter." << std::endl;
 }
 else
 {
  std::cout << "You have " << quarters << " quarters." << std::endl;
 }

 // 根据半美元硬币数量打印单数或复数形式
 if (half_dollars == 1)
 {
  std::cout << "You have " << half_dollars << " half dollar." << std::endl;
 }
 else
 {
  std::cout << "You have " << half_dollars << " half dollars." << std::endl;
 }

 // 根据一美元硬币数量打印单数或复数形式
 if (one_dollars == 1)
 {
  std::cout << "You have " << one_dollars << " one-dollar coin." << std::endl;
 }
 else
 {
  std::cout << "You have " << one_dollars << " one-dollar coins." << std::endl;
 }

 // 计算所有硬币的总价值（以美分为单位）
 total_cents = (one_dollars * 100) + (half_dollars * 50) + (quarters * 25) + (dimes * 10) + (nickels * 5) + pennies;

 // 打印所有硬币的总价值（以美分为单位）
 std::cout << "The value of all of your coins is " << total_cents << " cents." << std::endl;

 // 计算总价值中的美元部分
 int dollars = total_cents / 100;
 // 计算总价值中的美分余数部分
 int cents_remainder = total_cents % 100;

 // 打印总价值（以美元和美分格式，美分部分补零至两位）
 std::cout << "You have $" << dollars << "."
           << std::setw(2) << std::setfill('0') << cents_remainder << std::endl;

 // 程序正常退出
 return 0;
}