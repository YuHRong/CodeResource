// 将一个数组拆分为两个数组，一个为奇数数组，一个为偶数数组：
#include <stdio.h>

int main(void)
{
 int array[10] = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
 int even[10], odd[10];
 int e, d;

 e = d = 0;

 for (int loop = 0; loop < 10; loop++)
 {
  if (array[loop] % 2 == 0)
  {
   even[e] = array[loop];
   e++;
  }
  else
  {
   odd[d] = array[loop];
   d++;
  }
 }

 printf("the original array is ");
 for (int loop = 0; loop < 10; loop++)
  printf(" %d", array[loop]);

 printf("\n The even is ");
 for (int loop = 0; loop < e; loop++)
  printf(" %d", even[loop]);

 printf("\n The odd is ");
 for (int loop = 0; loop < d; loop++)
  printf(" %d", odd[loop]);

 return 0;
}