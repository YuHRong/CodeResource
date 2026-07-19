// Write a C# program to count a specified number in a given array of integers.


Console.WriteLine("Input an integer : ");
int n = Convert.ToInt32(Console.ReadLine());

// 定义一个具有自定义值的数组
int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };

// 显示一条消息，指示阵列中正在搜索的数字
Console.WriteLine("Number of " + n + " present in the said array:");

// 统计'nums'数组中输入整数'n'的出现次数，并打印计数结果
Console.WriteLine(nums.Count(x => x == n));