// 使用 for 循环迭代出输出元素，并将各个元素相加：
#include <stdio.h>

int main(void)
{
 int array[10] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
 int sum = 0;

 for (int loop = 9; loop >= 0; loop--)
 {
  sum = sum + array[loop];
 }
 printf("The sum of elements is: %d", sum);

 return 0;
}