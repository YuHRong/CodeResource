using class2;

class Program
{
 static void Main()
 {
  Console.WriteLine("输入半径: ");
  double radius = Convert.ToDouble(Console.ReadLine());

  Circle circle = new Circle(radius);

  double area = circle.CalculateArea();
  double circumference = circle.calculateCircumference();

  Console.WriteLine("面积是： {0:F4}", area);
  Console.WriteLine("周长是： {0:F4}", circumference);
 }
}