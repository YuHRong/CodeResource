// 无法转换
using System;
class Test
{
 public static void Main()
 {
  float[] float_arr = new float[10];
  int[] int_arr = new int[10];
  float_arr = int_arr;
 }
}