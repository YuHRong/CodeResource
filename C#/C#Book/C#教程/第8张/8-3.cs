using System;
class Test
{
 static int Find(int value, int[] array)
 {
  int i = 0;
  while (array[i] != value)
   {
   if (++i > array.Length)
    Console.WriteLine("Can not find");
  }
  return i;
 }
 static void Main()
 {
  Console.WriteLine(Find(3, new int[] { 5, 4, 3, 2, 1 }));
 }
}