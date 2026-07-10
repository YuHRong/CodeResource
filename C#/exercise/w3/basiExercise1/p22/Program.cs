// Check Within 20 of 100 or 200
// Write a C# program to check if the given integer is within 20 of 100 or 200.

using System.Reflection.Emit;

int num;

Console.Write("Input an integer: ");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(result(num));

bool result(int n)
{
 if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
  return true;
 return false;
}