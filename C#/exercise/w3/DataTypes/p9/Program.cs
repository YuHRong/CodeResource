// Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.

char ch;

Console.Write("Input a symbol: ");
ch = Convert.ToChar(Console.ReadLine());

if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
{
 Console.WriteLine("It's a lowercase vowel.");
}
else if (ch >= 0 && ch <= 9)
{
 Console.WriteLine("It's a digit.");
}
else
{
 Console.WriteLine("It's another symbol.");
}

