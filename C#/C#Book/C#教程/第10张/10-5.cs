using System;

class Text
{
 int x;
 static int y;
 void f()
 {
  x = 1;    // 正确,等价于 this.x = 1 
  y = 1;   // 正确,等价于 Test.y = 1 
 }

 static void G()
 {
  x = 1;    // 错误 不能访问 this.x 
  y = 1;    // 正确,等价于 Test.y = 1 
 }

 static void Main()
 {
  Text t = new Testc();
  t.x = 1;    // 正确
  t.y = 1;    // 错误 不能在类的实例中访问静态成员 
  Text.y = 1;    // 正确 
 }
}