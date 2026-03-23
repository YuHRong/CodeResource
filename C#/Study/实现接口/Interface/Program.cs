public interface IVehicle
{
 int Speed { get; set; }
 string Color { get; set; }

 // 添加 Drive方法
 void Drive();
}

public class Car : IVehicle
{
 private int _speed;
 private string _color;

 public int Speed
 {
  get { return _speed; }
  set { _speed = value; }
 }

 public string Color
 {
  get { return _color; }
  set { _color = value; }
 }

 public void Drive()
 {
  // drive 方法的输出
  Console.WriteLine("The car is driving.");
 }
}

public class Bike : IVehicle
{
 public void Drive()
 {
  Console.WriteLine("The bike is moving.");
 }
}