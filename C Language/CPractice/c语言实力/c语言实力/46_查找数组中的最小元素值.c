// 使用 for 循环迭代出输出元素，从第一元素开始逐个比较，获取最小的元素：
#include <stdio.h>

int main()
{
 int array[10] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
 int smallest = array[0];;

 for (int loop = 1; loop < 10; loop++)
 {
  if (smallest > array[loop])
   smallest = array[loop];
 }
 printf("The smallest emenent is %d\n", smallest);

 return 0;
}