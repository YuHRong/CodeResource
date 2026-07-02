#include <stdio.h>

double harmean(double x, double y);

int main(void)
{
 double x, y;

 printf("Enter two double-type numbers: \n");
 while (scanf("%lf %lf", &x, &y) == 2)
 {
  // 检查是否为零
  if (x == 0 || y == 0)
  {
   printf("Numbers cannot be 0.\n");
   continue;
  }

  // 打印结果
  printf("The harman of (%g, %g) is %g\n", x, y, harmean(x, y));
  printf("Enter next double-type number (q to quit):");
 }
 printf("Bye.\n");

 return 0;
}

double harmean(double x, double y)
{
 // 计算调和平均数：两个倒数的平均值的倒数
 return 1 / ((1.0 / 2.0) * (1 / x + 1 / y));
}