using System;
class Test
{
 public static void Main()
 {
  short a = 10;
  ushort b = 10;
  int c = 10;
  uint d = 10;
  Console.WriteLine(~10);
  Console.WriteLine("short: {0}",~a);
  Console.WriteLine("ushort: {0}", ~b);
  Console.WriteLine("int: {0}", ~c);
  Console.WriteLine("uint: {0}", ~d);
 }
}