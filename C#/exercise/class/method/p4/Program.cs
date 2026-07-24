// 递归计算阶乘

class Program
{
 public int Factorial(int n)
 {
  // 0 = 1, 1 = 1
  if (n <= 1)
   return 1;

  // 递归步骤：n = n × (n-1)
  return n * Factorial(n - 1);
 }

 static void Main(string[] args)
 {
  var p = new Program();

  Console.WriteLine($"6! = {p.Factorial(6)}");
  Console.WriteLine($"7! = {p.Factorial(7)}");
  Console.WriteLine($"8! = {p.Factorial(8)}");
 }
}
