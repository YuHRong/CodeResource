// Write a C# program to check if a number appears as the first or last element of an array of integers. The array length is 1 or more.


Console.WriteLine("\nInput an integer:");

int x = Convert.ToInt32(Console.ReadLine());

//定义一个具有预定义值的整数数组“num”
int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };

// 检查数组'nums'的第一个元素是否等于'x'
// 或者，如果数组“nums”的最后一个元素等于“x”
// 打印这些条件之间的逻辑OR运算结果
Console.WriteLine((nums[0] == x) || (nums[nums.Length - 1] == x));