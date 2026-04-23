
namespace MethodsHomework;

public static class EnterNameMethods
{
public static string UserName()
 {
  Console.WriteLine("What is your name?");
  return Console.ReadLine() ?? "Guest";
 }
}
