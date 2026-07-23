// Write a C program that accepts some integers from the user and finds the highest value and the input position.

#include <stdio.h>

#define SIZE 5

int main()
{
 int n[SIZE];
 int large = 0, position;

 printf("Input %d integer: \n", SIZE);
 for (int i = 0; i < SIZE; i++)
 { // 循环写入五个整数
  scanf("%d", &n[i]);
 }

 // 循环便利输入数组的元素
 for (int i = 0; i < SIZE; i++)
 {
  // 使用 large 跟 n[i] 对比
  // 如果是最大数，将他赋值给 large
  if (n[i] > large)
  {
   large = n[i];

   // 如果找到最大数，将当前位置赋值给 position
   position = i + 1;
  }
 }

 printf("Highest value: %d\n", large);
 printf("Position: %d\n", position);

 return 0;
}