
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

 // 重在运算符 == 等于等于
 public static bool operator ==(Box lhs, Box rhs)
 {
  bool status = false;
  if (lhs._length == rhs._length && lhs._height == rhs._height
  && lhs._width == rhs._width)
  {
   status = true;
  }

  return status;
 }

 // 重在运算符 != 不等于
 public static bool operator !=(Box lhs, Box rhx)
 {
  bool status = false;
  if (lhs._length != rhx._length || lhs._height != rhx._width
  || lhs._height != rhx._height)
  {
   status = true;
  }

  return status;
 }

 // 重在运算符< 小于， > 大于，两个必须一起重在
 // 重在运算符 < 小于
 public static bool operator <(Box lhs, Box rhs)
 {
  bool status = false;
  if (lhs._length < rhs._length
  && lhs._width < rhs._width
  && lhs._height < rhs._height)
  {
   status = true;
  }

  return status;
 }
 // 重在 > 大于运算符
 public static bool operator >(Box lhs, Box rhs)
 {
  bool status = false;
  if (lhs._length > rhs._length
  && lhs._width > rhs._width
  && lhs._height > rhs._height)
  {
   status = true;
  }
  return status;
 }

 // 重在运算符，<= 小于等于，>= 大于等于，两个必须一起重在
 // <= 小于等于
 public static bool operator <=(Box lhs, Box rhs)
 {
  bool status = false;
  if (lhs._length <= rhs._length
  && lhs._width <= rhs._width
  && lhs._height <= rhs._height)
  {
   status = true;
  }
  return status;
 }
 // >= 大于等于
 public static bool operator >=(Box lhs, Box rhs)
 {
  bool status = false;
  if (lhs._length >= rhs._length
  && lhs._width >= rhs._width
  && lhs._height >= rhs._height)
  {
   status = true;
  }
  return status;
 }

 public override string ToString()
 {
  return String.Format("({0}， {1}， {2})", _length, _width, _height);
 }
}

class Program
{
 static void Main()
 {
  Box b1 = new Box();    // 申明 b1，类型为 Box
  Box b2 = new Box();    // 申明 b2， 类型为 Box
  Box b3 = new Box();    // 申明 b3,类型为 Box
  Box b4 = new Box();

  double volume = 0.0;   // 体积


  // box1 信息
  b1.SetLength(6.0);
  b1.SetWidth(7.0);
  b1.SetHeight(5.0);

  // box2 信息
  b2.SetLength(12.0);
  b2.SetWidth(13.0);
  b2.SetHeight(10.0);

  // 使用重载的 ToString() 显示两个盒子
  Console.WriteLine("Box 1: {0}", b1.ToString());
  Console.WriteLine("Box2： {0}", b2.ToString());

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

  // 比较这些盒子
  // > 大于运算符
  if (b1 > b2)
   Console.WriteLine("Box 1 大于 box 2");
  else
   Console.WriteLine("Box2 大于 box1");

  // < 小于运算符
  if (b1 < b2)
   Console.WriteLine("Box1 小于box2");
  else
   Console.WriteLine("Box2 小于 box1");

  // >= 大于等于运算符
  if (b1 >= b2)
   Console.WriteLine("Box1 大于等于 Box2");
  else
   Console.WriteLine("Box2 大于等于 box1");

  // <= 小于等于运算符
  if (b1 <= b2)
   Console.WriteLine("Box1 小于等于 Box2");
  else
   Console.WriteLine("Box2 小于等于 box1");

  // != 不等于运算符
  if (b1 != b2)
   Console.WriteLine("Box1 不等于 Box2");
  else
   Console.WriteLine("Box1 等于 box2");

  b4 = b3;
  // == 等于运算符
  if (b3 == b4)
   Console.WriteLine("Box3 等于 Box4");
  else
   Console.WriteLine("Box3 不等于 Box4");

 }
}
