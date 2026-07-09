// 计算两个时间段的差值

#include <stdio.h> // 引入标准输入输出头文件

struct TIME
{
 int second;  // 秒
 int minutes; // 分
 int hours;   // 时
};

void differenceBetweenTimePeriod(struct TIME t1, struct TIME t2, struct TIME *diff);

int main(void)
{
 struct TIME startTime, stopTime, diff;

 printf("输入开始时间: \n");
 printf("输入小时、分钟、秒：");
 scanf("%d %d %d", &startTime.hours, &startTime.minutes, &startTime.second);

 printf("输入停止时间: \n");
 printf("输入小时、分钟、秒: ");
 scanf("%d %d %d", &stopTime.hours, &stopTime.minutes, &stopTime.second);

 // 计算差值
 differenceBetweenTimePeriod(startTime, stopTime, &diff);

 printf("\n差值: %d:%d:%d - ", startTime.hours, startTime.minutes, startTime.second);
 printf("%d:%d:%d ", stopTime.hours, stopTime.minutes, stopTime.second);
 printf("= %d:%d:%d\n", diff.hours, diff.minutes, diff.second);

 return 0;
}

void differenceBetweenTimePeriod(struct TIME start, struct TIME stop, struct TIME *diff)
{
 if (stop.second > start.second)
 {
  --start.minutes;
  start.second += 60;
 }

 diff->second = start.second - stop.second;

 if (stop.minutes > start.minutes)
 {
  --start.hours;
  start.minutes += 60;
 }

 diff->minutes = start.minutes - stop.minutes;
 diff->hours = start.hours - stop.hours;
}