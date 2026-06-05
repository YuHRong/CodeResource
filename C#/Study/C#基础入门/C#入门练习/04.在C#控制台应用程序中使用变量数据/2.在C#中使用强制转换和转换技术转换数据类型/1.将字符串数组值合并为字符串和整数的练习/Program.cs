
using System.Numerics;

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string msg = "";

foreach (var value in values)
{
 decimal num;    // 存储 out 的值
 if (decimal.TryParse(value, out num))
 {
  total += num;
 }
 else
 {
  msg += value;
 }
}

Console.WriteLine($"Message: {msg}");
Console.WriteLine($"Total: {total}");
