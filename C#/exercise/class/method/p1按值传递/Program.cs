


class Program
{
 void Swap(int x, int y)
 {
  int temp = x;
  x = y;
  y = temp;

  Console.WriteLine($"方法内 x = {x}, y = {y}");    // 交换成功
 }

 static void Main(string[] args)
 {
  var p = new Program();
  int a = 100, b = 200;

  Console.WriteLine($"调用前 a = {a}，b = {b}");

  p.Swap(a, b);

  Console.WriteLine($"调用后 a = {a}, b = {b}");
 }
}

