//rect.cs 源文件 用于定义矩形类和正方形类
using System;

namespace MyShape
{

 //定义举行类
 public class Rectangle : Shape
 {
  protected int a;
  protected int b;

  public Rectangle(int va, int vb)
  {
   a = va;
   b = vb;
  }

  //重载虚方法，计算举行面积
  public override int GetArea()
  {
   int area = a * b;
   return area;
  }

  //重载虚方法，在屏幕上绘制举行
  public override void Draw()
  {
   Console.WriteLine("Rectangle:");
   Console.WriteLine("* * * * *");
   Console.WriteLine("*       *");
   Console.WriteLine("*       *");
   Console.WriteLine("* * * * *");
  }
 }

 // 定义正方形类
 public class Square : Rectangle
 {
  public Square(int va) : base(va, va)
  {
   ;
  }

  //重载,绘制正方形
  public override void Draw()
  {
   Console.WriteLine("Square");
   Console.WriteLine("* * * * *");
   Console.WriteLine("*       *");
   Console.WriteLine("*       *");
   Console.WriteLine("*       *");
   Console.WriteLine("* * * * *");
  }
 }
}