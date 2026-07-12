
//
// Print Odd Numbers 1 to 99
// Write a C# program to print odd numbers from 1 to 99. Prints one number per line.
//

Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");

for (int i = 1; i < 100; i++)
{
 if (i % 2 == 1)
 {
  Console.WriteLine(i);
 }
}