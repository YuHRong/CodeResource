// Write a C program to calculate the average mathematics marks of some students. Input 0 (excluding to calculate the average) or a negative value to terminate the input process.
/*
申明一个存储学生成绩的数组，
申明一个存储成绩总和的变量，
申明一个用于计数考试次数的变量，
申明一个存储平均成绩的变量，
以上变量用于计算平均成绩。
使用循环便利输入成绩，
使用 scanf() 函数获取成绩，输入0退出
*/

#include <stdio.h>

#define SIZE 50 // 数组大小

int main()
{
 // 申明成绩相关变量为 float 类型
 float grade[SIZE];
 float gradeSum = 0.0, avgGrade = 0.0;
 int count = 0; // 初始化计数变量为 0

 printf("Input Mathematics marks (0 to terminate): \n");

 for (;;)
 {
  if (count == SIZE)
  {
   printf("考试次数上限\n");
   break;
  }

  int j = scanf("%f", &grade[count]);

  if (j != 1)
  {
   printf("输入错误！请输入有效成绩");
   while (getchar() != '\n' && getchar() != EOF)
    ;
   continue;
  }

  if (grade[count] <= 0)
  {
   break;
  }
  else
  {
   gradeSum += grade[count]; // 统计成绩总和
   count++;
  }
 }

 if (count > 0)
 {
  avgGrade = gradeSum / (float)count;
  printf("Average marks in Mathematics: %.2f\n", avgGrade);
 }
 else
  printf("没有考试成绩，无法计算成绩\n");

 return 0;
}