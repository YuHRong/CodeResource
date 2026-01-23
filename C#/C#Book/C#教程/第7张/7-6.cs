using System;
class Test
{
 public static void Main()
 {
  int x = 16;
  Console.WriteLine(x);
  int y = x >> 2;
  Console.WriteLine(y);
  y = y >> 2;
  Console.WriteLine(y);
  y = y >> 2;
  Console.WriteLine(y);
 }
}