using System;

delegate int MyDelegate();    //  申明一个代表
public class MyClass
{
 public int InstanceMethod ()
 {
  Console.WriteLine("Call the instance method.");
  return 0;
 }

 static public int StaticMethod()
 {
  Console.WriteLine("Call the static method.");
  return 0;
 }
}

public class Test
{
 static public void Main()
 {
  MyClass p = new MyClass();     
  
  //  将代表指向非静态的方法  Instance   Method 
   MyDelegate d = new MyDelegate(p.InstanceMethod);    
  // 掉要非静态方法
  d();    
  
  // 将代表指向静态的方法  StaticMethod
  d = new MyDelegate(MyClass.StaticMethod);
  // 调用非静态方法
  d();
 }
}