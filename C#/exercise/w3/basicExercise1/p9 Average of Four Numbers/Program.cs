// Average of Four Numbers
// Write a C# Sharp program that takes four numbers as input to calculate and prConvert the average.
// 

double n1, n2, n3, n4;

Console.Write("Enter the first number: ");
n1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the second number: ");
n2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the third number: ");
n3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the four number: ");
n4 = Convert.ToDouble(Console.ReadLine());

double sum = n1 + n2 + n3 + n4;
double avg = sum / 4;

Console.WriteLine("The average of {0}, {1}, {2}, {3}, is: {4}", n1, n2, n3, n4, avg);