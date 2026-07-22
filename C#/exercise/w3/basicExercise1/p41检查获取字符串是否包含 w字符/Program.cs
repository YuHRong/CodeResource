// Write a C# program to check if a given string contains the 'w' character between 1 and 3 times.

string str;

Console.Write("Input a string (contains at least one 'w' char) : ");
str = Console.ReadLine();

// 检查字符串中是否包含 'w'
// bool isW = str.ToLower().Contains('w');

// Console.WriteLine(isW);

// Console.WriteLine(str.ToLower().Contains('w'));

// 统计 w 出现的次数并存储在 count 中
var count = str.ToLower().Count(s => s == 'w');

// 检查 w 出现的次数是否大于等于 1且小于等于 3
Console.WriteLine("Test the string contains 'w' character between 1 and 3 times: ");
Console.WriteLine(count >= 1 && count <= 3);