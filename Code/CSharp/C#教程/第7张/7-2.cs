using System;
using System.Security.Cryptography.X509Certificates;
enum Weekday
{
 Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
};
class Test
{
 public static void Main()
 {
  Weekday day1 = Weekday.Sunday;
  Weekday day2 = Weekday.Saturday;
  Weekday day3 = day1 + 6;
  Console.WriteLine(day1);
  Console.WriteLine(day2);
  Console.WriteLine(day3);
 }
}