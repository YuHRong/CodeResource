
namespace ex1;

class Caller
{
 public void CallerArea(Shape sh)
 {
  double a;
  a = sh.Area();
  Console.WriteLine($"面积 {a:F2}");
 }
}
