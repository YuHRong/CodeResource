using System;

class DKR
{
 public int x, y, z;

 public DKR(int vx, int vy, int vz)
 {
  x = vx;
    y = vy;
  z = vz;
 }

 public static DKR operator +(DKR d1, DKR d2)
 {
  DKR dkr = new DKR(0, 0, 0);
  dkr.x = d1.x + d2.x;
  dkr.y = d1.y + d2.y;
  dkr.z = d1.z + d2.z;
  return dkr;
 }
}

class Test
{
 public static void Main()
 {
  DKR d1 = new DKR(3, 2, 1);
  DKR d2 = new DKR(0, 6, 5);
  DKR d3 = d1 + d2;
  Console.WriteLine("The 3d locetion of d3 is:{0},{1},{2}", d3.x, d3.y, d3.z);
 }
}