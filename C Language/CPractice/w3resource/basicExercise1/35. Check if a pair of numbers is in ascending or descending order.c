// Write a C program to check if two numbers in a pair are in ascending order or descending order.
/*
获取两个输入的值，
如果第一个数大于第二个数，则他是降序
如果第一个数小于第二个数，则他是升序
*/

#include <stdio.h>

int main()
{
 int n1, n2;

 printf("Input a pair of numbers (for example 10,2 : 2,10):\n");
 printf("Input first number of the pair: ");
 scanf("%d", &n1);
 printf("Input second number of the pair: ");
 scanf("%d", &n2);

 if (n1 > n2)
 {
  printf("The pair is in descending order!\n");
 }
 else
 {
  printf("The pair is in ascending order!\n");
 }

 return 0;
}