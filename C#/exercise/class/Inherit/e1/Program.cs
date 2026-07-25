using System;

// 基类
class Shape
{

 public void SetWidth(int w)
 {
  width = w;
 }

 public void SetHeight(int h)
 {
  height = h;
 }

 protected int width;
 protected int height;
}

// 派生类
class Rectangle : Shape
{
 public int GetArea()
 {
  return (width * height);
 }
}

class RectangleTester
{
 static void Main()
 {
  Rectangle rect = new Rectangle();
  rect.SetWidth(5);
  rect.SetHeight(7);

  Console.WriteLine($"总面积 {rect.GetArea()}");
  Console.ReadKey();
 }
}