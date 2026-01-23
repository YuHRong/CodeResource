using System;

class Test
{
static void F(params int[] args)
 {
  Console.WriteLine("Array contains {0} elements:", args.Length);
  foreach (int i in args)
   Console.Write(" {0}", i);
  Console.WriteLine();
 }

 public static void Main()
 {
  int[] a = { 1, 2, 3 };
  F(a);
  F(10, 20, 30, 40);
  F();
 }
}