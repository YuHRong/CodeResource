// 将奇数数组与偶数数组合并为一个数组：
#include <stdio.h>

int main(void)
{
 int array[10];
 int even[5] = {0, 2, 4, 6, 8};
 int odd[5] = {1, 3, 5, 7, 9};

 int index, e, o;
 e = o = 5;
 index = 0;

 for (int loop = 0; loop < e; loop++)
 {
  array[index] = even[loop];
  index++;
 }

 for (int loop = 0; loop < o; loop++)
 {
  array[index] = odd[loop];
  index++;
 }

 printf("\nThe even is ");
 for (int loop = 0; loop < e; loop++)
  printf(" %d", even[loop]);

 printf("\nThe odd is ");
 for (int loop = 0; loop < o; loop++)
  printf(" %d", odd[loop]);

 printf("\nAfter merge is ");
 for (int loop = 0; loop < 10; loop++)
  printf("%d ", array[loop]);

 return 0;
}