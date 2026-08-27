// Write a program in C# Sharp to count the number of alphabets, digits and special characters in a string.

string? str;
int alphabets = 0, digits = 0, charactor = 0;

Console.Write("\n\nCount total number of alphabets, digits, and special characters:\n");
Console.Write("--------------------------------------------------------------------\n");

Console.Write("Input the string: ");
str = Console.ReadLine();

for (int i = 0; i < str.Length; i++)
{
 if (str.ToLower()[i] >= 'a' && str.ToLower()[i] <= 'z')
  alphabets++;
 else if (str[i] >= '0' && str[i] <= '9')
  digits++;
 else
  charactor++;
}

Console.WriteLine($"Number of Alphabets in the string is : {alphabets} ");
Console.WriteLine($"Number of Digits in the string is : {digits} ");
Console.WriteLine($"Number of Special characters in the string is : {charactor}");