//MyShape.cs 源文件 用于定义图形类 作为其它图形的基类
using MyMessage;
using MyShape;
using System;

namespace MyShape
{
 public class Shape
 {
  public virtual void Draw()
  {
   ;  // 虚方法，用于图形绘制
  }
  public virtual int GetArea()
  {
   return 0;  // 虚方法，用于计算图形面积
  }
 }
}