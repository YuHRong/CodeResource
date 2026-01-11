using System;

public class Count
{
 static int count;
 int number;

 public Count()
 {
  count = count + 1;
  number = count;
 }

 public void show()
 {
  Console.WriteLine("object{0}: count = {1}", number, count);
 }
}

class Test
{
 public static void Main()
 {
  Count a = new Count();
  a.show();
  Console.WriteLine();

  Count b = new Count();
  a.show();
  b.show();
  Console.WriteLine();

  Count c = new Count();
  a.show();
  b.show();
  c.show();
 }
}