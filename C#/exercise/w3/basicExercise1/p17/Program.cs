// Add First Character to Front and Back
// Write a C# program to create a string from a given string (length 1 or more) with the first character added at the front and back.
// 

// 申明一个字符串变量
string? str;

// 提示用户输入一个字符串
Console.Write("Input a string : ");
str = Console.ReadLine();

// if (string.IsNullOrEmpty(str))
if(str.Length < 1)
{
 Console.WriteLine("Please re-input");
}
else
{
 // var s = str?.Substring(0, 1);
 // Console.WriteLine(s + str + s);
 Console.WriteLine(startEnd(str));
}

string startEnd(string str)
{
 return str.Substring(0, 1) + str + str.Substring(0, 1);
}