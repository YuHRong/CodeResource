// Remove Character by Index
// Write a C# program that removes a specified character from a non-empty string using the index of a character.

string msg = "w3resource";

Console.WriteLine(msg.Remove(1, 1));
Console.WriteLine(msg.Remove(9, 1));
Console.WriteLine(msg.Remove(0, 1));

// 参考使用函数删除索引处的字符
Console.WriteLine("使用函数删除索引处的字符");

Console.WriteLine(remove_char("w3resource", 1)); // Removes character at index 1
Console.WriteLine(remove_char("w3resource", 9)); // Removes character at index 9 (if exists)
Console.WriteLine(remove_char("w3resource", 0)); // Removes character at index 0

string remove_char(string str, int n)
{
 // 使用 Remove() 删除索引 n 处的字符
 return str.Remove(n, 1);
}