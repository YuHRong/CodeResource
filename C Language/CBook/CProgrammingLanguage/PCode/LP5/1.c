/* 确定一个数的位数 */
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 int i, j;

 printf("Enter a number: ");
 scanf("%d", &i);

 if (i < 10)
 {
  j = 1;
  printf("The number %d has %d digits\n", i, j);
 }
 else  if (i < 100)
 {
  j = 2;
  printf("The number %d has %d digits\n", i, j);
 }
 else if (i < 1000)
 {
  j = 3;
  printf("The number %d has %d digits\n", i, j);
 }

 return 0;
}
