using System;
class Test
{
 public static void Main()
 {
  Console.WriteLine(1 is int);
  Console.WriteLine(1 is float);
  Console.WriteLine(1.0 is float);
  Console.WriteLine(1.0 is double);
 }
}