namespace 创建接口方法;

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
  //  Drive() 方法

          Console.WriteLine("The car is driving." );
 }
}
