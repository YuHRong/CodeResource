#include <stdio.h>

int main(void)
{
  int i, n;
  float array[100];

  printf("Enter element quantities: ");
  scanf("%d", &n);
  printf("\n");

  // 接受输入
  for (i = 0; i < n; i++)
  {
    printf("Enter number %d", i + 1);
    scanf("%f", &array[i]);
  }

  // �?�?，并将最大元素存储到 array[0]�?
  for (i = 1; i < n; ++i)
  {
    // 如果要查找最小值可以将 < 换成 >
    if (array[0] < array[i])
      array[0] = array[i];
  }
  printf("the largest element is %.2f\n", array[0]);
  printf("����Ԫ��ֵ�� %.2f\n", array[0]);

  return 0;
}