// Write a C program to input details for three students, sort them by total marks, and display the sorted list along with the average marks.

#include <stdio.h>

#define S 20
// 创建学生结构
struct Student
{
 char name[S];
 int age;
 int ID;
 float math;
 float computerBasic;
 float cLanguageBasic;
 float totalGrade;
 float avg;
};

int main(void)
{
 struct Student s1, s2, s3;
 float avgGrade, totalGrade;

 // 学生 1
 printf("Input details for Student 1:\n");
 printf("Name: ");
 scanf("%s", s1.name);
 printf("Age: ");
 scanf("%d", &s1.age);
 printf("ID: ");
 scanf("%d", &s1.ID);
 printf("Math: ");
 scanf("%f", &s1.math);
 printf("Computer basic: ");
 scanf("%f", &s1.computerBasic);
 printf("C language basic: ");
 scanf("%f", &s1.cLanguageBasic);

 // 学生 2
 printf("Input details for Student 2:\n");
 printf("Name: ");
 scanf("%s", s2.name);
 printf("Age: ");
 scanf("%d", &s2.age);
 printf("ID: ");
 scanf("%d", &s2.ID);
 printf("Math: ");
 scanf("%f", &s2.math);
 printf("Computer basic: ");
 scanf("%f", &s2.computerBasic);
 printf("C language basic: ");
 scanf("%f", &s2.cLanguageBasic);

 // 学生 3
 printf("Input details for Student 3:\n");
 printf("Name: ");
 scanf("%s", s3.name);
 printf("Age: ");
 scanf("%d", &s3.age);
 printf("ID: ");
 scanf("%d", &s3.ID);
 printf("Math: ");
 scanf("%f", &s3.math);
 printf("Computer basic: ");
 scanf("%f", &s3.computerBasic);
 printf("C language basic: ");
 scanf("%f", &s3.cLanguageBasic);

 // 计算学生总成绩和平均成绩
 // s1
 s1.totalGrade = s1.math + s1.computerBasic + s1.cLanguageBasic;
 s1.avg = s1.totalGrade / 3;

 // s2
 s2.totalGrade = s2.math + s2.computerBasic + s2.cLanguageBasic;
 s2.avg = s2.totalGrade / 3;

 // s3
 s3.totalGrade = s3.math + s3.computerBasic + s3.cLanguageBasic;
 s3.avg = s3.totalGrade / 3;

 // 进行总成绩判断
 if (s1.totalGrade >= s2.totalGrade && s1.totalGrade >= s3.totalGrade && s2.totalGrade >= s3.totalGrade)
 {
  printf("\nName: %s\n", s1.name);
  printf("Age: %d\n", s1.age);
  printf("ID: %d\n", s1.ID);
  printf("Math: %.2f\n", s1.math);
  printf("Computer basic: %.2f\n", s1.computerBasic);
  printf("C language basic: %.2f\n", s1.cLanguageBasic);
  printf("Total grade: %.2f\n", s1.totalGrade);
  printf("Average grade: %.2f\n", s1.avg);

  printf("\nName: %s\n", s2.name);
  printf("Age: %d\n", s2.age);
  printf("ID: %d\n", s2.ID);
  printf("Math: %.2f\n", s2.math);
  printf("Computer basic: %.2f\n", s2.computerBasic);
  printf("C language basic: %.2f\n", s2.cLanguageBasic);
  printf("Total grade: %.2f\n", s2.totalGrade);
  printf("Average grade: %.2f\n", s2.avg);

  printf("\nName: %s\n", s3.name);
  printf("Age: %d\n", s3.age);
  printf("ID: %d\n", s3.ID);
  printf("Math: %.2f\n", s3.math);
  printf("Computer basic: %.2f\n", s3.computerBasic);
  printf("C language basic: %.2f\n", s3.cLanguageBasic);
  printf("Total grade: %.2f\n", s3.totalGrade);
  printf("Average grade: %.2f\n", s3.avg);
 }
 else if (s1.totalGrade >= s3.totalGrade && s1.totalGrade >= s2.totalGrade && s3.totalGrade >= s2.totalGrade)
 {
  printf("\nName: %s\n", s1.name);
  printf("Age: %d\n", s1.age);
  printf("ID: %d\n", s1.ID);
  printf("Math: %.2f\n", s1.math);
  printf("Computer basic: %.2f\n", s1.computerBasic);
  printf("C language basic: %.2f\n", s1.cLanguageBasic);
  printf("Total grade: %.2f\n", s1.totalGrade);
  printf("Average grade: %.2f\n", s1.avg);

  printf("\nName: %s\n", s3.name);
  printf("Age: %d\n", s3.age);
  printf("ID: %d\n", s3.ID);
  printf("Math: %.2f\n", s3.math);
  printf("Computer basic: %.2f\n", s3.computerBasic);
  printf("C language basic: %.2f\n", s3.cLanguageBasic);
  printf("Total grade: %.2f\n", s3.totalGrade);
  printf("Average grade: %.2f\n", s3.avg);

  printf("\nName: %s\n", s2.name);
  printf("Age: %d\n", s2.age);
  printf("ID: %d\n", s2.ID);
  printf("Math: %.2f\n", s2.math);
  printf("Computer basic: %.2f\n", s2.computerBasic);
  printf("C language basic: %.2f\n", s2.cLanguageBasic);
  printf("Total grade: %.2f\n", s2.totalGrade);
  printf("Average grade: %.2f\n", s2.avg);
 }
 else if (s2.totalGrade >= s1.totalGrade && s2.totalGrade >= s3.totalGrade && s1.totalGrade >= s3.totalGrade)
 {
  printf("\nName: %s\n", s2.name);
  printf("Age: %d\n", s2.age);
  printf("ID: %d\n", s2.ID);
  printf("Math: %.2f\n", s2.math);
  printf("Computer basic: %.2f\n", s2.computerBasic);
  printf("C language basic: %.2f\n", s2.cLanguageBasic);
  printf("Total grade: %.2f\n", s2.totalGrade);
  printf("Average grade: %.2f\n", s2.avg);

  printf("\nName: %s\n", s1.name);
  printf("Age: %d\n", s1.age);
  printf("ID: %d\n", s1.ID);
  printf("Math: %.2f\n", s1.math);
  printf("Computer basic: %.2f\n", s1.computerBasic);
  printf("C language basic: %.2f\n", s1.cLanguageBasic);
  printf("Total grade: %.2f\n", s1.totalGrade);
  printf("Average grade: %.2f\n", s1.avg);

  printf("\nName: %s\n", s3.name);
  printf("Age: %d\n", s3.age);
  printf("ID: %d\n", s3.ID);
  printf("Math: %.2f\n", s3.math);
  printf("Computer basic: %.2f\n", s3.computerBasic);
  printf("C language basic: %.2f\n", s3.cLanguageBasic);
  printf("Total grade: %.2f\n", s3.totalGrade);
  printf("Average grade: %.2f\n", s3.avg);
 }
 else if (s2.totalGrade >= s3.totalGrade && s2.totalGrade >= s1.totalGrade && s3.totalGrade >= s1.totalGrade)
 {
  printf("\nName: %s\n", s2.name);
  printf("Age: %d\n", s2.age);
  printf("ID: %d\n", s2.ID);
  printf("Math: %.2f\n", s2.math);
  printf("Computer basic: %.2f\n", s2.computerBasic);
  printf("C language basic: %.2f\n", s2.cLanguageBasic);
  printf("Total grade: %.2f\n", s2.totalGrade);
  printf("Average grade: %.2f\n", s2.avg);

  printf("\nName: %s\n", s3.name);
  printf("Age: %d\n", s3.age);
  printf("ID: %d\n", s3.ID);
  printf("Math: %.2f\n", s3.math);
  printf("Computer basic: %.2f\n", s3.computerBasic);
  printf("C language basic: %.2f\n", s3.cLanguageBasic);
  printf("Total grade: %.2f\n", s3.totalGrade);
  printf("Average grade: %.2f\n", s3.avg);

  printf("\nName: %s\n", s1.name);
  printf("Age: %d\n", s1.age);
  printf("ID: %d\n", s1.ID);
  printf("Math: %.2f\n", s1.math);
  printf("Computer basic: %.2f\n", s1.computerBasic);
  printf("C language basic: %.2f\n", s1.cLanguageBasic);
  printf("Total grade: %.2f\n", s1.totalGrade);
  printf("Average grade: %.2f\n", s1.avg);
 }
 else if (s3.totalGrade >= s2.totalGrade && s3.totalGrade >= s1.totalGrade && s2.totalGrade >= s1.totalGrade)
 {
  printf("\nName: %s\n", s3.name);
  printf("Age: %d\n", s3.age);
  printf("ID: %d\n", s3.ID);
  printf("Math: %.2f\n", s3.math);
  printf("Computer basic: %.2f\n", s3.computerBasic);
  printf("C language basic: %.2f\n", s3.cLanguageBasic);
  printf("Total grade: %.2f\n", s3.totalGrade);
  printf("Average grade: %.2f\n", s3.avg);

  printf("\nName: %s\n", s2.name);
  printf("Age: %d\n", s2.age);
  printf("ID: %d\n", s2.ID);
  printf("Math: %.2f\n", s2.math);
  printf("Computer basic: %.2f\n", s2.computerBasic);
  printf("C language basic: %.2f\n", s2.cLanguageBasic);
  printf("Total grade: %.2f\n", s2.totalGrade);
  printf("Average grade: %.2f\n", s2.avg);

  printf("\nName: %s\n", s1.name);
  printf("Age: %d\n", s1.age);
  printf("ID: %d\n", s1.ID);
  printf("Math: %.2f\n", s1.math);
  printf("Computer basic: %.2f\n", s1.computerBasic);
  printf("C language basic: %.2f\n", s1.cLanguageBasic);
  printf("Total grade: %.2f\n", s1.totalGrade);
  printf("Average grade: %.2f\n", s1.avg);
 }
 else
 {
  printf("\nName: %s\n", s3.name);
  printf("Age: %d\n", s3.age);
  printf("ID: %d\n", s3.ID);
  printf("Math: %.2f\n", s3.math);
  printf("Computer basic: %.2f\n", s3.computerBasic);
  printf("C language basic: %.2f\n", s3.cLanguageBasic);
  printf("Total grade: %.2f\n", s3.totalGrade);
  printf("Average grade: %.2f\n", s3.avg);

  printf("\nName: %s\n", s1.name);
  printf("Age: %d\n", s1.age);
  printf("ID: %d\n", s1.ID);
  printf("Math: %.2f\n", s1.math);
  printf("Computer basic: %.2f\n", s1.computerBasic);
  printf("C language basic: %.2f\n", s1.cLanguageBasic);
  printf("Total grade: %.2f\n", s1.totalGrade);
  printf("Average grade: %.2f\n", s1.avg);

  printf("\nName: %s\n", s2.name);
  printf("Age: %d\n", s2.age);
  printf("ID: %d\n", s2.ID);
  printf("Math: %.2f\n", s2.math);
  printf("Computer basic: %.2f\n", s2.computerBasic);
  printf("C language basic: %.2f\n", s2.cLanguageBasic);
  printf("Total grade: %.2f\n", s2.totalGrade);
  printf("Average grade: %.2f\n", s2.avg);
 }

 // 计算所有学生的总成绩和平均分并打印
 totalGrade = s1.totalGrade + s2.totalGrade + s3.totalGrade;
 avgGrade = totalGrade / 3;

 printf("\nTotal grade of the three students: %.3f\n", totalGrade);
 printf("Average is: %.3f\n", avgGrade);

 return 0;
}