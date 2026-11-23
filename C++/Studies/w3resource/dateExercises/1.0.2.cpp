#include <iostream>
#include <ctime>

int main()
{
 time_t crtime; // 声明一个变量，将当前时间保存为自纪元以来的秒数

 struct tm *time_info; // 声明一个指向结构的指针以保存时间信息
 time(&crtime);        // 获取自epoch和stor以来的当前系统时间（秒）
 char result[80];      // 声明一个数组，将格式化时间存储为字符串

 // e it in crtime
 time_info = localtime(&crtime); // 将当前时间转换为本地时间结构

 // 根据指定的格式“%d-%m-%Y%H:%m:%S”将time_info格式化为字符串
 strftime(result, sizeof(result), "%d-%m-%Y %H:%M:%S", time_info); // 格式化时间为字符串
 std::cout << result << '\n';                                      // 输出格式化的时间字符串

 return 0;
}