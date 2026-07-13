// Remove 'HP' from String
// Write a C# program to check if "HP" appears at the second position in a string and return the string without "HP".

// 申明一个保存 PHP Tutorial 的字符串
string str = "PHP Tutorial";

// 检查索引第二个位置开始是否包含 'HP'，并删除返回字符串。
Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str));