using System;
//它给出了我们常用的值类型在系统环境中的原型定义 
class Test
{
 public static void Main()
 {
  float[] float_arr = new float[10];
  double[] double_arr = new double[10];
  sbyte[] sbyte_arr = new sbyte[10];
  byte[] byte_arr = new byte[10];
  ushort[] ushort_arr = new ushort[10];
  int[] int_arr = new int[10];
  long[] long_arr = new long[10];
  string[] string_arr = new string[10];
  Console.WriteLine(float_arr);
  Console.WriteLine(double_arr);
  Console.WriteLine(sbyte_arr);
  Console.WriteLine(byte_arr);
  Console.WriteLine(ushort_arr);
  Console.WriteLine(int_arr);
  Console.WriteLine(long_arr);
  Console.WriteLine(string_arr);
 }
}