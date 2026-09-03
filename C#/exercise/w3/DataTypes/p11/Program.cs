// Write a C# Sharp program that takes a decimal number as input and displays its equivalent in binary form.

int n;

Console.WriteLine("Input the number: ");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Binary equivalent: {0}", Convert.ToString(n, 2));
