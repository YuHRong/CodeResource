namespace ex1;

class Triangle : Shape
{
 private double _length, _width;

 public Triangle(double l = 0, double w = 0)
 {
  _length = l;
  _width = w;
 }

 public override double Area()
 {
  Console.WriteLine("Triangle 类的面积");
  return _length * _width / 2;
 }
}
