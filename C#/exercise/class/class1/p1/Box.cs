
namespace p1;

public class Box
{
 private double Length;  // 长
 private double Height;  // 高
 private double Width;  // 宽

 public void DisplayMessage()
 {
  Console.WriteLine("输入长度");
  Length = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("输入宽度");
  Width = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("输入高度");
  Height = Convert.ToDouble(Console.ReadLine());
 }

 public double Volume()
 {
  return Length * Width * Height;
 }

 public void Display()
 {
  Console.WriteLine($"长 = {Length}");
  Console.WriteLine($"宽 = {Width}");
  Console.WriteLine($"高 = {Height}");
  Console.WriteLine($"体积 = {Volume()}");
 }

}
