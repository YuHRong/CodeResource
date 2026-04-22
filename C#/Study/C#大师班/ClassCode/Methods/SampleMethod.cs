
namespace Methods;

public static class SampleMethod
{
 public static void SayHi(string firstName)
 {
  Console.WriteLine("What your name");
  string name = Console.ReadLine();
  Console.WriteLine($"My name is: {name}.");
  Console.WriteLine($"Hello: {firstName}");

 }
}
