// Write a C# program to get the largest value between the first and last element of an array (length 3) of integers.

int[] arr1 = { 1, 1, 5, 10, 7, 9, 11 };

Console.WriteLine($"Array1: [{string.Join(", ", arr1)}");

// 初始化变量存储最大值
var temp = arr1[0];

// 使用 for 循环便利数组中的元素
for (int i = 0; i < arr1.Length; i++)
{
 //检查当前元素是否大于第一个元素
 if (arr1[i] > arr1[0])
  // 将最大值赋值给 temp
  temp = arr1[i];
}

// 显示数组第一个值和最后一个值之间的最大值
Console.WriteLine("\nHighest value between first and last values of the said array: {0}", temp);