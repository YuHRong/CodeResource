// 小球自由下落
// 一球从100米高度自由落下，每次落地后反跳回原高度的一半；再落下，求它在第10次落地时，共经过多少米？第10次反弹多高？

#include <stdio.h>

#define INITIAL_HEIGHT 100.0
#define BOUNCE_COUNT 10

int main(void)
{
  double h = INITIAL_HEIGHT;
  double s = INITIAL_HEIGHT;

  // 第一次反弹高度
  h /= 2;

  // 计算后续反弹高度和总路程
  for (int i = 2; i <= BOUNCE_COUNT; i++)
  {
    s += 2 * h;
    h /= 2;
  }

  // 输出结果，指定小数位数为2位
  printf("第 %d 次落地时，共经过 %.5f 米,第 %d 次返回 %.5f 米\n", BOUNCE_COUNT, s, BOUNCE_COUNT, h);

  return 0;
}