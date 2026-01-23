using System;

class Vehicle // 定义汽车类
{
 public int wheels; // 公有成员：轮子个数
 protected float weight; // 保护成员：重量

 public Vehicle() { }

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