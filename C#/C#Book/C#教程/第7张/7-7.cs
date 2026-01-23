using System;
class Test
{
 public static void Main()
 {
  int x = 5;
  int y = x++;
  Console.WriteLine(y);
  y = ++x;
  Console.WriteLine(y);
 }
}