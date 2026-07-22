// Check for 20 or Sum Equals 20
// Write a C# program to check the sum of the two given integers. Return true if one of the integers is 20 or if their sum is 20.

int n1, n2;

Console.Write("Input first integer: ");
n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer: ");
n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((n1 == 20 || n2 == 20) || (n1 + n2 == 20));