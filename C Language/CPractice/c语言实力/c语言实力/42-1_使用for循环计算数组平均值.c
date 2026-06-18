// 使用 for 循环迭代出输出元素，并将各个元素相加算出总和，再除于元素个数：
#include <stdio.h>

int main(void)
{
 int array[10] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
 int sum, loop;
 float avg;

 sum = avg = 0;

 for (loop = 0; loop < 10; loop++)
 {
  sum = sum + array[loop];
 }

 avg = (float)sum / loop;

 printf("avg is: %.2f", avg);

 return 0;
}