// 通过用户输入指定的数值，来判断最大值。
#include <stdio.h>
#include <stdlib.h>

int main(void)
{
 int i, n;
 float *data;

 printf("输入元素个数(1 - 100): ");
 scanf("%d", &n);

 // 为 'n' 元素分配内存
 data = (float *)calloc(n, sizeof(float));
 if (data == NULL)
 {
  printf("Error!!! 内存没有分配。");
  exit(0);
 }
 printf("\n");

 // 用户输入
 for (i = 0; i < n; ++i)
 {
  printf("输入数字 %d: ", i + 1);
  scanf("%f", data + i);
 }

 // 循环找出最大值
 for (i = 1; i < n; ++i)
 {
  // 如果需要找出最小值可以将 < 改为 >
  if (*data < *(data + i))
   *data = *(data + i);
 }

     printf("最大元素 = %.2f", *data);
free(data);    // 释放内存

     return 0;
}