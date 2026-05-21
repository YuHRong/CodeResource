

using System;
using System.Collections.Generic;

namespace 继承演示
{
 public class Program
 {
  static void Main(string[] args)
  {
   Car car = new Car();

   Console.ReadLine();
  }
 }

 public class Smartphone
 {

 }

 public class Cellphone : Phone
 {
  public List<string> App { get; set; }
 }

 public class Phone
 {
  public void PlaceCall()
  {

  }

  public void EndCall()
  {

  }
 }
}

