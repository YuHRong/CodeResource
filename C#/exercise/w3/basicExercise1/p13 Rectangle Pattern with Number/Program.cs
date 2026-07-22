// Rectangle Pattern with Number
// Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit.

int num;
Console.Write("Enter a number: ");
num = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < 1; i++)
{
 Console.WriteLine($"{num}{num}{num}");
 for(int j = 0; j < 3; j++)
 {
  Console.WriteLine($"{num} {num}");
 }
 Console.WriteLine("{0}{0}{0}", num);
}