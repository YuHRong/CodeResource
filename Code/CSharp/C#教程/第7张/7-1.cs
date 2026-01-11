using System;
class Test
{
 static void F(int x, int y, int z)
 {
  Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
 }
 public static void Main()
 {
  int i = 0; F(i++, i++, i++);
 }
}