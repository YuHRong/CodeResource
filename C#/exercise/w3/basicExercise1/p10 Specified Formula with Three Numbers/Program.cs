// Specified Formula with Three Numbers
// Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.

int x, y, z, result;

Console.Write("Enter first number - ");
x = Convert.ToInt16(Console.ReadLine());
Console.Write("Enter second number - ");
y = Convert.ToInt16(Console.ReadLine());
Console.Write("Enter third number - ");
z = Convert.ToInt16(Console.ReadLine());

result = (x + y) * z;
Console.Write($"Result of specified numbers {x}, {y} and {z} (x+y).z is {result} ");

result = (x * y) + (y * z);
Console.WriteLine($"and x.y + y.z is {result}");