// Write a C program to read an array of length 6, change the first element by the last, the second element by the fifth and the third element by the fourth. Print the elements of the modified array.

#include <stdio.h>

#define SIZE 6

int main(void)
{
 // 申明一个 int 类型数组，长度为 SIZE
 int arr[SIZE];
 int t; // 申明一个中间变量用于交换数组的元素

 // 提示输入 SIZE 个元素
 printf("Input the %d members of the array: \n");
 for (int i = 0; i < SIZE; i++)
 { // 使用循环逐个读取书入的元素并存入 arr1 数组中
  scanf("%d", &arr[i]);
 }

 /*
 *    指定6个元素数组交换
  // 交换数组的第一个元素和最后一个元素
 t = arr[0];
 arr[0] = arr[SIZE - 1];
 arr[SIZE - 1] = t;

 // 交换数组的第二个和第五个元素
 t = arr[1];
 arr[1] = arr[SIZE - 2];
 arr[SIZE - 2] = t;

 // 交换数组的第三个元素和第四个元素
 t = arr[2];
 arr[2] = arr[SIZE - 3];
 arr[SIZE - 3] = t;
*/

 // 使用数组的前半部分交换后半部分
 // 不限制数组长度
 for (int i = 0; i < SIZE; i++)
 {
  if (i < (SIZE / 2))
  {
   t = arr[i];
   arr[i] = arr[SIZE - (i + 1)];
   arr[SIZE - (i + 1)] = t;
  }
 }

 // 循环打印交换后的数组
 for (int i = 0; i < SIZE; i++)
  printf("Array_n[%d] = %d\n", i, arr[i]);

 return 0;
}