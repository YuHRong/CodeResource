// Write a program in C# Sharp to copy one string to another string.

string? str1;
int count = 0;

Console.WriteLine("Input the string: ");
str1 = Console.ReadLine();

string[] str2 = new string[str1.Length];

for (int i = 0; i < str1.Length; i++)
{
 string sCount = str1.ToString();
 str2[i] = sCount;
 count++;
}

Console.Write("\nThe First string is: {0}\n", str1);
Console.Write("The Second string is: {0}\n", string.Join("", str2)); // Join characters in str2 to form a string
Console.Write("Number of characters copied: {0}\n\n", count);