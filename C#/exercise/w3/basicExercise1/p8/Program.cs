//
// Multiplication Table
// Write a C# Sharp program that prints the multiplication table of a number as input.
//

int inputNumber, result;

Console.Write("Inter the number: ");
inputNumber = int.Parse(Console.ReadLine());

for (int i = 0; i <= 10; i++)
{
 result = inputNumber * i;
 Console.WriteLine($"{inputNumber} * {i} = {result}");
}