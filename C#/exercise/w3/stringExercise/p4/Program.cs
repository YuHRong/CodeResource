// Write a program in C# Sharp to print individual characters of the string in reverse order.

Console.Write("\n\nPrint individual characters of the string in reverse order:\n");
Console.Write("------------------------------------------------------\n");

Console.WriteLine("Input the string : ");
string str = Console.ReadLine();

Console.WriteLine("The characters of the string in reverse are : \n");

// 使用 for 循环从字符串中的最后一个字符递减并打印
for (int i = str.Length - 1; i >= 0; i--)
{
 Console.Write(str[i] + " ");
}