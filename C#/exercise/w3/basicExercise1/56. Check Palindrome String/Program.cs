// Write a C# program to check if a given string is a palindrome or not.

Console.WriteLine("Enter the string: "); ;
string? str = Console.ReadLine();

Console.WriteLine($"For '{str}' the output should be ");
Console.WriteLine(CharPalindrome(str));

static bool CharPalindrome(string inputStr)
{
 // 将字符串拆分为字符数组
 char[] c = inputStr.ToCharArray();

 // 反转字符数组
 Array.Reverse(c);

 // 检查原始字符串是否等于反转字符串
 return new string(c).Equals(inputStr);
}