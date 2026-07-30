using ex1;

class Circle : Shape
{
 private double _radius;

 public Circle(double r = 0)
 {
  _radius = r;
 }

 public override double Area()
 {
  Console.WriteLine("Circle 类的面积");
  return Math.PI * Math.Pow(_radius, 2);
 }
}