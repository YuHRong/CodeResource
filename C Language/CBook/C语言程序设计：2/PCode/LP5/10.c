#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int grade, grade_ten;

 printf("Enter numerical grade: ");
  scanf("%d", &grade);

 if (grade < 0 || grade > 100)
 {
  printf("Error, grade must be between 0 and 100.");
  return;
 }

 grade_ten = grade / 10;
 switch (grade_ten) {
 case 9: case 10:
  printf("Letter grade: A");
  break;
 case 8:
  printf("Letter grade: B");
  break;
 case 7:
  printf("Letter grade: C");
  break;
 case 6:
  printf("Letter grade: D");
  break;
 default:
  printf("Letter grade: F");
  break;
 }

 return 0;
}