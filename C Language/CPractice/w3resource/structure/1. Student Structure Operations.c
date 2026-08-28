// Create a structure called "Student" with members name, age, and total marks. Write a C program to input data for two students, display their information, and find the average of total marks.

#include <stdio.h>

#define SIZE 50

struct Student
{
 char name[SIZE];
 int age;
 double totalGrade;
};

int main(void)
{
 struct Student s1, s2;
 double avg;

 printf("Input details for Student 1:\n");
 printf("Name: ");
 scanf("%s", s1.name); // 假设名称没有空格
 printf("Age: ");
 scanf("%d", &s1.age);
 printf("Total Marks: ");
 scanf("%lf", &s1.totalGrade);

 printf("Input details for Student 2:\n");
 printf("Name: ");
 scanf("%s", s2.name);
 printf("Age: ");
 scanf("%d", &s2.age);
 printf("Total Marks: ");
 scanf("%lf", &s2.totalGrade);

 // 打印学生信息
 // 学生 1
 printf("\nStudent 1 Information:\n");
 printf("Name: %s\n", s1.name);
 printf("Age: %d\n", s1.age);
 printf("Total Marks: %.2lf\n", s1.totalGrade);

 // 学生 2
 printf("\nStudent 2 Information:\n");
 printf("Name: %s\n", s2.name);
 printf("Age: %d\n", s2.age);
 printf("Total Marks: %.2lf\n", s2.totalGrade);

 // 计算两个同学的平均分
 avg = (s1.totalGrade + s2.totalGrade) / 2;
 printf("\nAverage Total Marks: %.2f\n", avg);
}