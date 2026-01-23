using System;

class Vehicle    // 定义汽车类
{
 public int wheels;     // 公有成员，轮子个数
 protected float weight;    // 保护成员，重量

 public Vehicle(int w, float g)
 {
  wheels = w;
  weight = g;
 }

 public virtual void Speak()
 {
  Console.WriteLine("the w vehicle is speaking!");
 }
}

class Car : Vehicle    // 定义轿车类
{
 int passenger;    // 私有成员，乘客数

 public Car(int w, float g, int p) : base(w, g)
 {
  wheels = w;
  weight = g;
  passenger = p;
 }

 public override void Speak()
 {
  Console.WriteLine("The car is speaking:Di-di!");
 }
}

class Truck : Vehicle    // 定义卡车类
{
 int passenger;    // 私有成员，乘客数
 float load;    // 私有成员，载重量

 public Truck(int w, float g, int p, float l) : base(w, g)
 {
  wheels = w;
  weight = g;
  passenger = p;
  load = l;
 }

 public override void Speak()
 {
  Console.WriteLine("The truck is speaking:Ba-ba!");
 }
}

class Test
{
 public static void Main()
 {
  Vehicle v1 = new Vehicle();
  Car c1 = new Car(4, 2, 5);
  Truck t1 = new Truck(6, 5, 3, 10);

  v1.Speak();
  v1 = c1;
  v1.Speak();
  c1.Speak();

  v1 = t1;
  v1.Speak();
  t1.Speak();
 }
}