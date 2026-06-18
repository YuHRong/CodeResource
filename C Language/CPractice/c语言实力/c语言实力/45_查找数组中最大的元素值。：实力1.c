// 查找数组中最大的元素值
#include <stdio.h>

int main(void)
{
 int array[10] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
 int max;

 max = array[0];

 for (int loop = 1; loop < 10; loop++)
 {
  if (max < array[loop])
   max = array[loop];
 }

 printf("Elements max is %d\n", max);

 return 0;
}