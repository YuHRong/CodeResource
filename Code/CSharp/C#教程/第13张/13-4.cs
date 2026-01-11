using System;

class Team
{
 string[] s_name = new string[8];

 public string this[int nIndex]
 {
  get
  {
  return s_name[nIndex];
  }
  set
  {
   s_name[nIndex] = value;
  }
 }
}

class Test
{
 public static void Main()
 {
  Team t1 = new Team();
  for(int i = 1; i < 6;i++)
   Console.WriteLine(t1[i]);
 }
}