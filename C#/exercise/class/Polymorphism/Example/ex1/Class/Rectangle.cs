namespace ex1;

class Rectangle : Shape
{
 private double _Length;
 private double _width;

 public Rectangle(double l = 0, double w = 0)
 {
  _Length = l;
  _width = w;
 }

 public override double Area()
 {
  Console.WriteLine("Rectangle 类的面积");
  return _Length * _width;
 }
}
