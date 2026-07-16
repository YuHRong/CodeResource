// Write a C# program to create a string where the first 4 characters are in lower case. If the string is less than 4 letters, make the whole string in upper case.

string str;


Console.Write("Input a string : ");
str = Console.ReadLine();

if (str.Length >= 4)
{
 // 如果字符串长度大于4，则将前四个字符转换为大写
 // 并将字符串剩余部分添加并打印
 Console.WriteLine(str.Substring(0, 4).ToUpper() + str.Substring(4, str.Length - 4));
}
else    // 若字符串长度小于 4，则将全部字符转换为大写 Console.WriteLine(str.ToUpper());