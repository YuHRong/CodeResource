#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void) {
 int score;
 char grade;

 printf("ÇëÊäÈë³É¼¨£º ");
 scanf("%d", &score);
 grade = (score >= 90) ? 'A' : ((score >= 60) ? 'B' : 'C');

 printf("%c\n", grade);

 return 0;
}