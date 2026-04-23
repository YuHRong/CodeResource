
namespace StaticClass;

public class UserMessage
{
 public static void ApplicationStartMessage()
 {
  Console.WriteLine("欢迎使用 Static 静态类演示应用程序！");

  Console.ReadLine();
  Console.Clear();

  int hoursDay = DateTime.Now.Hour;
  //hoursDay = 22;
  Console.WriteLine(hoursDay);
  if (hoursDay < 12)
   Console.WriteLine("Good Morning!");
  else if (hoursDay < 19)
   Console.WriteLine("Good Afternoon!");
  else
   Console.WriteLine("Good Evening!");
 }
}
