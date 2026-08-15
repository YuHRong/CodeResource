// Write a C# Sharp program that takes a number and a width also a number. It then displays a triangle of that width using that number.

int n, width;

Console.Write("Input an integer: ");
n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the desired width: ");
width = Convert.ToInt32(Console.ReadLine());

for (int row = 0; row < width; row++)
{
 for (int col =width; col > row; col--)
 {
  Console.Write(n);
 }
 Console.WriteLine();
}
