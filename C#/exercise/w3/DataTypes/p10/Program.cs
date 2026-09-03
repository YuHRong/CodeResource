// Write a C# Sharp program that takes two numbers as input and returns true or false when both numbers are even or odd.

int n1, n2;

Console.WriteLine("Input two integer: ");
n1 = Convert.ToInt32(Console.ReadLine());
n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((n1 % 2 == 0  && (n2 % 2) == 0) || (n1 % 2 != 0 && (n2 % 2) != 0));