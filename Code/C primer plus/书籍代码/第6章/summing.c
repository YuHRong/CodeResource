/* summing.c -- 根据用户键入的整数求和 */
#include<stdio.h>
int main(void) 
{
 long num;
 long sum = 0L;        // 先把sum初始化为0
 int status;

 printf("Please enter an integer to be summed ");
 printf("(q to quit): ");
 status = scanf_s("%ld", &num);
 while (status == 1)        // == 表示等于的意思
 {
  sum = sum + num;
  printf("Please enter nest integer (q to quit): ");
  status = scanf_s("%ld", &num);
 }
 printf("Those integers sum to %ld.\n", sum);

 return 0;
}