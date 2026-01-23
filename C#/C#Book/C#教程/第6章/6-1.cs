using System;
class Test
{
 public static void Main()
 {
  byte x = 16;
  Console.WriteLine("x = {0}", x);
  ushort y = x;
  Console.WriteLine("y = {0}", y);
  y = 65535;
  Console.WriteLine("y = {0}", y);
  float z = y;
  Console.WriteLine("z = {0}", z);
 }
}