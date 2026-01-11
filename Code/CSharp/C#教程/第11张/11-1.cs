using System;

class Test
{
 public int max(int x, int y)
 {
  if (x > y)
   return x;
  else return y;
 }

 static void Main()
 {
  Test test = new Test();
  Console.WriteLine("tha Max of 6 and is: {0}",
   test.max(6, 8));
 }
}