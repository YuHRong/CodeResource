using System;
class Test
{
 public static void Main(string[] args)
 {
  switch (args.Length)
  {
   case 0:
    Console.WriteLine("No arguments were provided");
    break;
   case 1:
    Console.WriteLine("One arguments was provided");
    break;
   default:
    Console.WriteLine("{0} arguments were provided");
    break;
  }
 }
}
