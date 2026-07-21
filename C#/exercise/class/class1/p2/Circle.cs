namespace class2;

public class Circle
{
 private double _radius;

 public Circle(double radius)
 {
  _radius = radius;
 }

 public double CalculateArea()
 {
  return Math.PI * Math.Pow(_radius, 2);
 }

 public double calculateCircumference()
 {
  return 2 * _radius * Math.PI;
 }

 public double Radius
 {
  get { return _radius; }
 }

}
