using System;

interface IInteger
{
 void Add(int i);
}

interface IDouble
{
 void Add(double d);
}

interface INumber : IInteger, IDouble
{

}

class C
{
 void Test(INumber n)
 {
  //n.Add(1); 错误 
  n.Add(1.0);
  // 正确 
  ((IInteger)n).Add(1); // 正确 
  ((IDouble)n).Add(1);
  // 正确 
 }
}