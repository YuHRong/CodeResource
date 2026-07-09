// Arithmetic Operations
// Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.

int num1, num2;

Console.Write("Input the first number: ");
num1 = int.Parse(Console.ReadLine());
Console.Write("Input the second number: ");
num2 = int.Parse(Console.ReadLine());

int sum = num1 + num2;
Console.WriteLine($"{num1} + {num2} = {sum}");

int sub = num1 - num2;
Console.WriteLine($"{num1} - {num2} = {sub}");

int product = num1 * num2;
Console.WriteLine($"{num1} x {num2} = {product}");

int div = num1 / num2;
Console.WriteLine($"{num1} / {num2} = {div}");

int mod = num1 % num2;
Console.WriteLine($"{num1} mod {num2} = {mod}");