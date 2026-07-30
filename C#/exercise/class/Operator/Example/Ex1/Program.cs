class Box
{
 private double _length;
 private double _width;
 private double _height;

 public double GetVolume()
 {
  return _length * _width * _height;
 }

 public void SetLength(double len)
 {
  _length = len;
 }
 public void SetWidth(double wid)
 {
  _width = wid;
 }
 public void SetHeight(double high)
 {
  _height = high;
 }

 // 重载 + 运算符来把两个 Box 对象相加
 public static Box operator +(Box b, Box c)
 {
  Box box = new Box();

  box._length = b._length + c._length;
  box._width = b._width + c._width;
  box._height = b._height + c._height;
  return box;
 }
}

class Program
{
 static void Main()
 {
  Box b1 = new Box();    // 申明 b1，类型为 Box
  Box b2 = new Box();    // 申明 b2， 类型为 Box
  Box b3 = new Box();    // 申明 b3,类型为 Box

  double volume = 0.0;   // 体积


  // box1 信息
  b1.SetLength(6.0);
  b1.SetWidth(7.0);
  b1.SetHeight(5.0);

  // box2 信息
  b2.SetLength(12.0);
  b2.SetWidth(13.0);
  b2.SetHeight(10.0);

  // box1 的体积
  volume = b1.GetVolume();
  Console.WriteLine($"box 1 的体积是 {volume}");

  // box2 的体积
  volume = b2.GetVolume();
  Console.WriteLine($"Box 2 的体积是 {volume}");

  // 将两个对象相加
  b3 = b1 + b2;

  // b3 的体积
  volume = b3.GetVolume();
  Console.WriteLine($"Box 3 的体积是 {volume}");

 }
}
