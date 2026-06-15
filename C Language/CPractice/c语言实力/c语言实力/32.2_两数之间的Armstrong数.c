#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<math.h>

int main(void)
{
 int n1, n2, i, temp1, temp2, remainder, n = 0, result = 0;

 printf("输入两个整数: ");
 scanf("%d %d", &n1, &n2);

 printf("%d 和 %d 之间的 Armstrong 数为: ", n1, n2);

 for (i = n1 + 1; i < n2; ++i)
 {
  temp2 = i;
  temp1 = i;

  // 计算
  while (temp1 != 0)
  {
   temp1 /= 10;
   ++n;
  }

  while (temp2 != 0)
  {
   remainder = temp2 % 10;
   result += pow(remainder, n);
   temp2 /= 10;
  }

  if (result == i)
  {
   printf("\n%d ", i);
  }

  n = 0;
  result = 0;
 }
 printf("\n");

 return 0;
}