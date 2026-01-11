using System;
class Class1 { }
class Class2 : Class1 { }
class Test
{
 public static void Main()
 {
  Class1[] class1_arr = new Class1[10];
  Class2[] class2_arr = new Class2[10];
  class1_arr = class2_arr;
 }
}