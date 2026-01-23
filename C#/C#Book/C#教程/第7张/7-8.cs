using System;
class Test
{
 public static void Main()
 {
  int x = 5;
  Console.WriteLine((x++) + (x++) + (x++));
  int y = (x++) + (x++) + (x++);
  Console.WriteLine(y);
 }
}