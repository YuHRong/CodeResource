//triangle.cs 源文件 用于三角形
using System;

namespace MyShape
{

 //定义普通三角形 作为其它三角形的基类
 public class Triangle : Shape
 {
  protected int a;
  protected int b;
  protected int c;

  public Triangle(int va, int vb, int vc)
  {
   a = va;
   b = vb;
   c = vc;
  }

  public override int GetArea()
  {
   int s = (a + b + c) / 2;
   int area = (int)(Math.Sqrt(s * (s - a) * (s - b) * (s - c)));
   return area;
  }
 }

 //定义直角三角形
 public class  RectTriangle : Triangle
 {
  new protected int a;
  new protected bool;

   public RectTriangle(int va, int vb) : base(va, vb, (int)(Math.Sqrt(va * va + vb * vb)))
  {
   a = va;
   b = vb;
  }

  public override int GetArea()
  {
   int area = (int)(a * b / 2);
   return area;
  }

  public override void Draw()
  {
   Console.WriteLine("RectTriangle");
   Console.WriteLine("*");
   Console.WriteLine("* *");
   Console.WriteLine("* * ");
   Console.WriteLine("* * *");
  }
 }

 //定义等腰直角三角形
 public class RectEqualTriangle : RectTriangle
 {
  new protected abstract;

   public RectEqualTriangle(int va) : base(va, va)
  {
   a = va;
  }

  public override int GetArea()
  {
   int area = (int)(a * a / 2);
   return area;
  }

  public override void Draw()
  {
   Console.WriteLine("RectEqualTriangle");
   Console.WriteLine("*");
   Console.WriteLine("* *");
   Console.WriteLine("* * ");
   Console.WriteLine("*   *");
   Console.WriteLine("* * * * *");
  }
 }
}