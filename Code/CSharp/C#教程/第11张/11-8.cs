using System;
using System.Timers;

class Student     // 定义学生类
{
 public string s_name;

 public int s_age;

 public float s_weight;

 public Student(string n, int  a, float w)
 {
  s_name = n;
  s_age = a;
  s_weight = w;
 }

 public int max_age(int x, int y)
 {
  if (x > y)
  return x;
else
   return y;
 }

 public float max_weight(float x, float y)
 {
  if (x > y)
   return x;
  else
   return y;
 }
}

class Test
{
 public static void Main()
 {
  Student s1 = new Student("mike", 21, 70);
  Student s2 = new Student("john", 21, 70);
  if (s1.max_age(s1.s_age, s2.s_age) == s1.s_age)
   Console.WriteLine("{0}'s age is bigger than {1}'s",
    s1.s_name, s2.s_name);
  Console.WriteLine("{0}'s age is smaller than {1}'s",
   s1.s_name, s2.s_name);

  if (s1.max_weight(s1.s_weight, s2.s_weight) == s1.s_weight)
   Console.WriteLine("{0}'s weight is biggerthan {1}'s",
    s1.s_name, s2.s_name);
  else
   Console.WriteLine("{0}'s weight is smaller than {1}'s",
    s1.s_name, s2.s_name);
 }
}