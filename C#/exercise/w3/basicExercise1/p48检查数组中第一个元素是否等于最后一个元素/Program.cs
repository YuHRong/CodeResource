//Write a C# program that checks if the first element and the last element of an array of integers are equal. The array length is 1 or more.

int[] num = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };

//使用 字符串 Join() 方法分割并存储
Console.WriteLine($"\nArray1: [{string.Join(", ", num)}]");


// 检查数组长度是否大于等于 1
// 且第一个元素与最后一个元素相等
Console.WriteLine(((num.Length >= 1) && num[0].Equals(num[num.Length - 1])));