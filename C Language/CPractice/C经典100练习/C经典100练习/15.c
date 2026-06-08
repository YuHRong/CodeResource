// 学习成绩 >= 90分的同学用A表示，60 - 89分之间的用B表示，60分以下的用C表示。
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void) {
 int score;
 char grade;

 printf("请输入成绩： ");
 scanf("%d", &score);

 if (score < 60) {
 grade  = 'C';
  printf("成绩： %d分，等级： %c\n", score, grade);
 }
 else if (score < 90) {
  grade = 'B';
  printf("成绩： %d分，等级： %c\n", score, grade);
 }
 else {
  grade = 'A';
  printf("成绩：%d分，等级： %c\n", score, grade);
 }

 return 0;
}