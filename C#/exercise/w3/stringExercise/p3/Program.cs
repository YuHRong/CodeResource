// Write a C# Sharp program to separate individual characters from a string.

Console.Write("\n\nSeparate the individual characters from a string:\n");
Console.Write("------------------------------------------------------\n");

Console.WriteLine("Input the string : ");
string str = Console.ReadLine();

Console.WriteLine("The characters of the string are : ");

//foreach (char ch in str)
//{
//Console.Write(ch + " ");
//}

int count = 0;
while (count < str.Length)
{
 Console.Write(str[count] + " ");   // 显示每一个字符
 count++;     // 移动到字符串中的下一个字符
}
Console.WriteLine();