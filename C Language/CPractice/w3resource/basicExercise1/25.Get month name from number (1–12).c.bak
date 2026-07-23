// Write a C program that reads an integer between 1 and 12 and prints the month of the year in English.

#include <stdio.h>

int main()
{
 const char *months[] = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
 int i, n;

 printf("Input a number between 1 to 12to get the month name: ");
 // 将输入的值读入 i
 i = scanf("%d", &n);

 // 判断输入的是否是一个整数
 if (i != 1)
 {
  printf("Error: Input an intger, please.\n");
 }
 else // 如果输入的是整数，进入 else 条件
 {
  // 检查输入的范围是否在 1 到 12之内
  if (n >= 0 && n <= 12)
  {
   // 如果在 1 到 12 范围内，打印对应月份
   printf("\n%s\n", months[n - 1]);
  }
  else // 如果不在 1 到12范围内
  {
   printf("\nOut of range\n");
  }
 }

 return 0;
}