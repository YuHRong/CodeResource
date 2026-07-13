// Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.

// 申明两个整数变量
int n1, n2;

// 提示输入并写入第一个整数
Console.WriteLine("Input a first intger: ");
n1 = Convert.ToInt32(Console.ReadLine());

// 提示输入并写入第二个整数
Console.WriteLine("Input a second integer: ");
n2 = Convert.ToInt32(Console.ReadLine());

// 检查第一个整数是否大于 -10且第二个数小于 10并打印
Console.WriteLine((n1 > -10 && n2 < 10));