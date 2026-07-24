// 表达式体
// 方法重载（Overloading）

class Calculator
{
 // 重载 1：两个 int 相加
 public int Add(int a, int b) => a + b;

 // 重载 2：三个 int 相加
 public int Add(int a, int b, int c) => a + b + c;

 // 重载 3：两个 double 相加
 public double Add(double a, double b) => a + b;

 static void Main()
 {
  var cal = new Calculator();

  // 调用重载 1
  Console.WriteLine(cal.Add(1, 2));

  // 调用重载 2
  Console.WriteLine(cal.Add(1, 2, 3));

  // 调用重载 3
  Console.WriteLine(cal.Add(1.5, 2.3));
 }
}
