// Write a C# program to create a string of four copies, taking the last four characters from a given string. If the given string is less than 4, return the original one.

string str = "";

Console.WriteLine("\nInput a string: ");
str = Console.ReadLine();

if (str.Length > 4)
{
 for (int i = str.Length - 4; i < str.Length; i++)
 {
  Console.Write(str[i]);
 }
}
else
{
 Console.WriteLine(str);
}