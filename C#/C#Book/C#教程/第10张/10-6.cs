using System;

class Vehicle        // 定义汽车类
{
 public int wheels;       // 共有成员， 轮子个数

 protected float weight;      //保护成员 重量 

 public Vehicle() {; }

 public Vehicle(int w, float g)
 {
  wheels = w;
  weight = g;
 }

 public void Show()
 {
  Console.WriteLine("the wheel of vehicle is: {0}", wheels);
  Console.WriteLine("the weight of vehicle is: {0}", weight);
 }
}

class train       // 定义火车类
{
 public int num;     // 公有成员，车厢数目
 private int passengers;      // 私有成员，乘客数
 private float weight;      // 私有成员，重量

 public train() {; }

 public train(int n, int p, float w)
 {
  num = n;
  passengers = p;
  weight = w;
 }

 public void Show()
 {
  Console.WriteLine("The num of train is: {0}", num);
  Console.WriteLine("The weight of train is: {0}", weight);
  Console.WriteLine("The passengers train car is: {0}", passengers);
 }
}

class Car:Vehicle     // 定义轿车类
{
 int passenger;    // 私有成员，乘客数

 public Car(int w, float g, int p) : base(w, g)
 {
  wheels = w;
  weight = g;
  passenger = p;
 }

 new public void Show()
 {
  Console.WriteLine("The wheel of car is: {0}", wheels);
  Console.WriteLine("The weight of car is: {0}", weight);
  Console.WriteLine("The passengers of car is:{0}", passenger);
 }
}

class Test
{
 public static void Main()
 {
  Vehicle v1 = new Vehicle(4, 5);
  train t1 = new train();
  train t2 = new train(10, 100, 100);
  Car c1 = new Car(4, 2, 4);
  v1.Show();
  t1.Show();
  t2.Show();
c1.Show();
 }
}