// Absolute Difference or Double It
// Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than the second number.
// 

double n1, n2;

Console.Write("Input first number: ");
n1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input second number: ");
n2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(SubAbs(n1, n2));

double SubAbs(double a, double b)
{
 return a > b ? (a - b) * 2 : b - a;
}