using System;

class A
{
 public int x;

 public void Main()
 {
  x = 5;
  Console.WriteLine("The value of x is: {0}", x);
  Console.WriteLine("The value of this.x is: {0}", this.x);
 }
}

class Program
{
 static void Main()
 {
  A myA = new A();
  myA.Main(); // 调用A类的实例方法
 }
}