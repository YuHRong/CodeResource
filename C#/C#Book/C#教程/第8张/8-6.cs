using System;
class Hello
{
 static void Main()
 {
  System.Console.WriteLine(@"hello,
#if Debug world
#else everyone
#endif ");
 }
}