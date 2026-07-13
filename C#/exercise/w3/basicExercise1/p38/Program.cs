// Extract 'PH' from String
// Write a C# program to get a string of two characters from a given string. The first and second characters of the given string must be "P" and "H", so PHP will be "PH".

// 申明一个保存 PHP字符串的变量
string str = "PHP";
string str2 = "";    // 申明一个返回新字符串的变量

// 检查字符串长度是否大于1，且第一个字符为 P
if(str.Length > 1 && str[0] == 'P')
{
 // 如果条件为真，将 P 赋值给 str2
 str2 += str[0];
}

// 检查 str 长度是否大于 2，且第二个字符为 H
if(str.Length > 2 && str[1] == 'H')
{
 // 如果条件为真，则将 H 附加到 str2 字符串后
 str2 += str[1];
}

// 打印 str2 字符串
Console.WriteLine(str2);