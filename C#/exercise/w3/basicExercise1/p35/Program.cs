// Write a C# program to check two given numbers where one is less than 100 and the other is greater than 200.

// 申明两个保存整数的变量
double n1, n2;

// 提示输入并写入第一个数字小于 100
Console.WriteLine("Input a first number(<100)");
n1 = Convert.ToDouble(Console.ReadLine());

// 提示输入并写入第二个数字（>200）
Console.WriteLine("Input a second number(>200):");
n2 = Convert.ToDouble(Console.ReadLine());

// 检查第一个数字是否小于 100 且第二个数字大于 200
Console.WriteLine((n1 < 100 && n2 > 200));