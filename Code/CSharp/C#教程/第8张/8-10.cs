using System;
class Jumptest
{
 public static void Main()
 {
  try
  {
   Console.WriteLine("try");
   goto leave;
  }
  finally
  {
   Console.WriteLine("Finllay");
  }
 leave:
  Console.WriteLine("leave");
 }
}