
using System.Security.Cryptography.X509Certificates;

class Program
{
 // out 参数：方法负责赋值
 public void GetValue(out int x, out int y)
 {
  Console.WriteLine("请输入第一个值");
  x = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("请输入第二个值");
  y = Convert.ToInt32(Console.ReadLine());

  // 方法结束前必须给所有 out 赋值
 }

 // 实用示例：TryParse 模式
 public bool TryDivide(int a, int b, out double result)
 {
  if (b == 0)
  {
   result = 0;
   return false;
  }
  result = (double)a / b;

  return true;
 }

 static void Main(string[] args)
 {
  var p = new Program();

  // 参数无需初始化
  int a, b;
  p.GetValue(out a, out b);

  Console.WriteLine($"a={a}, b={b}");

  // TryParse 模式
  if (p.TryDivide(10, 3, out double res))
  Console.WriteLine($"10 / 3 = {res:F2}");  // 3.33

  // C# 7.0 内联模式
  // if (int.TryParse("123", out int number))
   // Console.WriteLine($"解析成功：{number}");
 }
}