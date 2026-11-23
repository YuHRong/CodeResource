// Write a C++ program to get the current date and time.

#include <iostream>
#include<ctime>

int main()
{
 //使用time_t数据类型的当前系统中的当前日期和时间
 time_t timeToday;
 time(&timeToday); // 获取当前时间

 std::cout << "The current date and time is:" << '\n';
 std::cout << asctime(localtime(&timeToday)) << '\n'; // 输出当前时间

 return 0;
}