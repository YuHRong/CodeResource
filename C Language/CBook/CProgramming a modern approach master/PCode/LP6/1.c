// 找出输入的最大数
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main(void)
{
 float n, max = 0.0f;

 for (;;)
 {
 printf("Enter a number: ");
 scanf("%f", &n);

 if (n < 0)
  break;

 if (n > max)
  max = n;
}
printf("The largest number entered was %.2f\n", max);

return 0;
}