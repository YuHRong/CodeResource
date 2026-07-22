// Check Positive and Negative Pair
// Write a C# program to check a pair of integers and return true if one is negative and one is positive.

Console.Write("Input first integer: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((x > 0 && y < 0) || (x < 0 && y > 0));
