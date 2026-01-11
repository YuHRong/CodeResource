using System;
enum Weekday
{
 Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday
}
class Test
{
 public static void Main()
 {
  Weekday day;
  day = (Weekday)6;
  Console.WriteLine(day);
 }
}