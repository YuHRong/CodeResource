using System;

class Vehicle     // 定义汽车类
{
 int wheels;      // 公有成员，轮子个数
 protected float weight; // 保护乘员，重量

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

class Car : Vehicle     // 定义轿车类，，从汽车类中继承
{
 int passengers;    // 私有成员，乘客数

 public Car(int w, float g, int p) : base(w, g)
 {
  wheels = w;
  weight = g;
  passengers = p;
 }
}