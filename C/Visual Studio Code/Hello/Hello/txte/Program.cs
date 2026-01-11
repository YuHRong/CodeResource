using System;
public enum Color
{
    red, blue, green
}
public struct Point
{
    public int x, y;
}
public interface IBase
{
    void F();
}
public interface IDerived : IBase
{
    void g();
}
public class A
{
    protected void H()
    {
        Console.WriteLine("A.H");
    }
}
public class B : A, IDerived
{
    public void F()
    {
        Console.WriteLine("B.F, implementation of IDerived.F"); ;
    }
    public void G()
    {
        Console.WriteLine("B.G, inplementation of IDerived.G");
    }
    override protected void H()
    {
        Console.WriteLine("B.H, override of A.H");
    }
}
public delegate void EmptyDelegate();
