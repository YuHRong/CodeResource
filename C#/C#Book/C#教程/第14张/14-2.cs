using System;

class Vehicle      // 定义汽车类
{
 public int wheels;    // 公有成员，轮子个数
 protected float weight;     // 保护乘员，重量

 public Vehicle() { }

 public Vehicle(int w, float g)
 {
  wheels = w;
  weight = g;
 }

 public void Speak()
 {
  Console.WriteLine("the w vehicle is speaking!");
 }
}

class Car : Vehicle     // 定义轿车类
{
 int passenger;    // 私有成员，乘客数

 public Car(int w, float g, int p)
 {
  wheels = w;
  weight = g;
  passenger = p;
 }

 new public void Speak()
 {
  Console.WriteLine("Di-di!");
 }
}