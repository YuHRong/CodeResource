// Define a structure named Time with members hours, minutes, and seconds. Write a C program to input two times, add them, and display the result in proper time format.

#include <stdio.h>

// 定义时间结构体
struct Time
{
 int hours;
 int minutes;
 int seconds;
};

int main(void)
{
 // 定义结构变量存储两个时间和结果
 struct Time t1, t2, result;

 // 输入时间 1
 printf("Input the first time (hours minutes seconds): ");
 scanf("%d %d %d", &t1.hours, &t1.minutes, &t1.seconds);

 // 输入时间 2
 printf("Input the second time (hours minutes seconds): ");
 scanf("%d %d %d", &t2.hours, &t2.minutes, &t2.seconds);

 // 将两次时间相加
 result.seconds = t1.seconds + t2.seconds;
 result.minutes = t1.minutes + t2.minutes + result.seconds / 60;
 result.hours = t1.hours + t2.hours + result.minutes / 60;

 // 调整分钟和秒
 result.minutes %= 60;
 result.seconds %= 60;

 // 显示结果
printf("\nResultant Time: %02d:%02d:%02d\n", result.hours, result.minutes, result.seconds);

 return 0;
}