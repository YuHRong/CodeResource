using System;
class Test
{
 static void Main()
 {
  long longValue = Int64.MaxValue;
  int intValue = (int)longValue;
  Console.WriteLine("(int) {0} = {1}", longValue, intValue);
 }
}