//兔子生崽）：有一对兔子，从出生后第3个月起每个月都生一对兔子，小兔子长到第三个月后每个月又生一对兔子，假如兔子都不死，问每个月的兔子总数为多少？（输出前40个月
//  本程序打印斐波那契数列的前20项
#include<stdio.h>

int main(void)
{
 int a = 1, b = 1, temp, i;

 // 输出前两项
 printf("%12d%12d", a, b);

 for (i = 3; i <= 20; i += 2)
 {
  // 计算下一项
  temp = a + b;

  // 输出下一项
  printf("%12d", temp);

  // 更新 a
  a = b;

  // 更新b
  b = temp;

  // 在计算下一项
  temp = a + b;

  // 输出并换行
  printf("%12d\n", temp);

  // 更新 a
  a = b;

  // 更新 temp
  b = temp;
 }

 return 0;
}