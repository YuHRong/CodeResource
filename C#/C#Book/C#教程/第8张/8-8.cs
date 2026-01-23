using System;
class Factorial 
{
 public static void Main(string[] args)
 {
  long nFactorial = 1;
  long nComputerto = Int64.Parse(args[0]);
  long nCurDig = 1;
  for (nCurDig = 1; nCurDig <= nComputerto ; nCurDig++)
   checked
   {
    nFactorial *= nCurDig;
   }
  Console.WriteLine("{0}! is {1}", nComputerto, nFactorial);
 }
}