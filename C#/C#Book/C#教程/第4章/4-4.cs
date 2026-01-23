using System;
class Test
{
 public static void Main()
 {
  int i = 10; object obj = i;
  //对象类型

  if (obj is int)
  {
   Console.Write("The value of i is boxing! ");
  }
  i = 20;
  // 改变 i 的值 
  Console.WriteLine("int: i = {0}", i);
  Console.WriteLine("object: obj = {0}", obj);
 }
}