// Write a C# program to check if a string starts with a specified word.
// Note: Suppose the sentence starts with "Hello"
// Sample Data: string1 = "Hello how are you?"
// Result: Hello.

string? str;

Console.Write("Input a string : ");
str = Console.ReadLine();

// 根据字符串检查并输出结果
// 检查字符串长度是否小于 6，是否等于 Hello
//或者检查字符串是否以“Hello”开头，索引5处的字符是否为（' '）
Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));