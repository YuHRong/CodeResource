// Write a C program to compute the sum of consecutive odd numbers from a given pair of integers.
/*
申明两个变量存储输入的值，
获取输入的两个值中的最小值，将他存储在第一个变量中，确保第一个值是最小值
以输入的两个变量作为循环初始值和循环条件，
获取两个数之间的奇数
将获取的奇数相加得到最后的和
*/

#include <stdio.h>

int main()
{
 int n1, n2, temp; // 申明存储输入两个值的变量，申明中间变量
 int oddSum = 0;   // 初始化存储奇数和的变量

 printf("Input a pair of numbers (for example 10,2):\n");
 printf("Input first number of the pair: ");
 scanf("%d", &n1);
 printf("Input second number of the pair: ");
 scanf("%d", &n2);

 if (n1 > n2)
 { // 如果 n1 大于 n2
  // 将最小值赋给 n1
  temp = n1;
  n1 = n2;
  n2 = temp;
 }

 printf("List of odd numbers: \n");
 for (int i = n1; i <= n2; i++)
 { // 循环便利输入值
  // 检查是否为奇数
  if ((i % 2) != 0)
  {
   // 如果是奇数打印奇数
   printf("%d \n", i);

   // 将奇数相加赋给 oddSum
   oddSum += i;
  }
 }

 printf("Sum = %d", oddSum);

 return 0;
}