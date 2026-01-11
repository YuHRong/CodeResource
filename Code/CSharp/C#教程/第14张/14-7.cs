using System;

class A
{
 public virtual void F()
 {
  Console.WriteLine("A.F");
 }
 public virtual void G()
 {
  Console.WriteLine("A.G");
 }
}

class B : A
{
 public sealed override void F()
 {
  Console.WriteLine("B.F");
 }

override public void G()
 {
  Console.WriteLine("B.G");
 }
}

class C : B
{
override public void G()
 {
  Console.WriteLine("C.G");
 }
}