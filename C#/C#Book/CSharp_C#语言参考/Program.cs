using System;
    class Test {
    static void F(int p)
    {
        Console.WriteLine("p = {0}", p);
        p++;
    }
static void Main()
{
    int a = 1;
    Console.WriteLine("pre: a = {0}", a);
    F(a);
    Console.WriteLine("post: a = {0}", a);
    }
}