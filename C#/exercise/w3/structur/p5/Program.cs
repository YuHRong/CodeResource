// Write a program in C# Sharp that shows what happens when a structure and a class instance are passed to a method.

using static System.Console;

public class NewClass
{
 public int n;    // 类的成员变量
}

public struct NewStruct
{
 public int n;    // 结构成员变量
}

public class Program
{
 // 在NewStruct实例中修改“n”值的方法
 public static void TrackStruct(NewStruct st)
 {
  st.n = 8;    // 修改传递的newStruct实例的“n”值（由于按值传递，不会影响原始值）
 }

 // 在newClass实例中修改“n”值的方法
 public static void TrackClass(NewClass cs)
 {
  cs.n = 8;    // 在newClass实例中修改“n”值的方法
 }

 // Main 方法
 public static void Main()
 {
  Write("\n\nWhen a structure and a class instance is passed to a method :\n");
  Write("--------------------------------------------------------------\n");

  //创建newStruct和newClass的实例
  NewStruct nS = new NewStruct();
  NewClass nC = new NewClass();

  //为newStruct和newClass实例的'n'分配初始值
  nS.n = 5;
  nC.n = 5;

  // 调用 TrackStruct 方法传递newStruct实例（由于按值传递，不会修改原始实例）
  TrackStruct(nS);
  // 调用TrackClass方法传递newClass实例（由于通过引用传递，将修改原始实例）
  TrackClass(nC);

  // 在方法调用后显示newStruct和newClass实例中的“n”值
  WriteLine($"\nns.n = {nS.n}");    //在newStruct实例中显示“n”的值（未更改）
  WriteLine($"nc.n = {nC.n}\n");    //在newClass实例中显示“n”的值（已修改）
 }
}