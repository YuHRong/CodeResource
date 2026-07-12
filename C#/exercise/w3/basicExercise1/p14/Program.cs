// Celsius to Kelvin and Fahrenheit
// Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.

double celsius, fahrenheit, kelvin;

Console.Write("Enter the amount of celsius: ");
celsius = Convert.ToDouble(Console.ReadLine());

kelvin = celsius + 273.15;
Console.WriteLine(($"Kelvin = {kelvin}"));

fahrenheit = celsius * 1.8 + 32;
Console.WriteLine($"Fahrenheit = {fahrenheit}");
