using System;


class Program
{ 
 // 引用传递：x 和 y 直接引用 a、b 的内存
 public void Swap(ref int x, ref int y)
 {
  int temp = x;
  x = y;
  y = temp;
 }

 static void Main(string[] args)
 {
  var p = new Program();
  int a = 100, b = 200;

Console.WriteLine($"调用前， a = {a}, b = {b}");

p.Swap(ref a, ref b);

Console.WriteLine($"调用后， a = {a}, b = {b}");
 }
}