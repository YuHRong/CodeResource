// Print Age Message
// Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You look older than 20".

int age;

Console.Write("Enter your age - ");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("You look older than {0}", age);