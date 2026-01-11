using System;

class Text
{
 static void Swap(int x, int y)
 {
  int temp = x;
  x = y;
  y = temp;
 }

 static void Main()
 {
  int i = 1, j = 2;
  Swap(i, j);
  Console.WriteLine("i = {0}, j = {1}",
   i, j);
 }
}