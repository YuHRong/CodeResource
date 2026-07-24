// Write a C++ program to calculate the sum of all even and odd numbers in an array.

#include <iostream>

int main()
{
 int arr[] = {1, 2, 3, 4, 5, 6, 7, 8};
 int ar = sizeof(arr) / sizeof(arr[0]);
 int oddSum = 0, evenSum = 0;

 std::cout << "Original array: ";
 // 循环变量输出数组的元素
 for (int i = 0; i < ar; i++)
 {
  std::cout << arr[i] << " ";
 }
 std::cout << '\n';

 // 找出数组中奇数和偶数
 for (int i = 0; i < ar; i++)
 {
  if ((arr[i] % 2) == 0)
  { // 使用取模运算符，若余数位 0 求偶数的和
   evenSum += arr[i];
  }
  else
  { // 否则求奇数的和
   oddSum += arr[i];
  }
 }

 std::cout << "Sum of all even and odd numbers: " << evenSum << ", " << oddSum << std::endl;

 return 0;
}