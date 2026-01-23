using System;

namespace Program1
{
 public class A
 {
  public static readonly int X = 1;
 }
}

namespace program2
{
 class Test
 {
  static void Main()
  {
   Console.WriteLine(Program1.A.X);
  }
 }
}