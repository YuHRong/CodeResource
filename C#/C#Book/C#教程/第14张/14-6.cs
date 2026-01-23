using System;

abstract class Vehicle // 定义汽车类
{
 public int wheels; // 公有成员 轮子个数
 protected float weight; // 保护成员 重量

 public Vehicle(int w, float g)
 {
  wheels = w;
  weight = g;
 }

 public abstract void Speak();
}

class Car : Vehicle // 定义轿车类
{
 int passengers; // 私有成员 乘客数

 public Car(int w, float g, int p) : base(w, g)
 {
  wheels = w;
  weight = g;
  passengers = p;
 }

 public override void Speak()
 {
  Console.WriteLine("The car is speaking:Di-di!");
 }
}

class Truck : Vehicle // 定义卡车类
{
 int passengers; // 私有成员 乘客数
 float load; // 私有成员 载重量

 public Truck(int w, float g, int p, float l) : base(w, g)
 {
  wheels = w;
  weight = g;
  passengers = p;
  load = l;
 }

 public override void Speak()
 {
  Console.WriteLine("The truck is speaking:Ba-ba!");
 }
}