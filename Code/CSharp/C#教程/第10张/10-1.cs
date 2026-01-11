using System;

class Vehicle    // 定义汽车类
{
 public int wheels;    // 公有成员,轮子个数
 protected float weight;     // 保护成员，重量
 public void F()
 {
  wheels = 4;    // 正确，允许访问自身成员
  weight = 10;    // 正确，允许访问自身成员
 }
}

class train     // 定义火车类
{
 public int num;      // 公有成员，车厢数目
 private int passengers;     // 私有成员乘客数
 private float weight;       // 私有成员，重量
 public void F()
 {
  num = 5;    // 正确，允许访问自身成员
  weight = 100;    // 正确，允许访问自身成员
  Vehicle v1 = new Vehicle();
  v1.wheels = 4;    // 正确，允许访问v1的公有成员
  v1.weight = 6;     // 错误，不允许访问v1的保护成员，可以修改为
  weight = 6;
 }
}

class Car : Vehicle     // 定义轿车类
{
 int passengers;     // 私有成员，乘客数
  public void F()
 {
  Vehicle v1 = new Vehicle();
  v1.wheels = 4;     // 正确，允许访问公有成员
  v1.weight = 6;    // 正确，允许访问 V1 的保护成员
 }
}