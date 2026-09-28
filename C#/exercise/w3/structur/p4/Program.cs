// Write a C# Sharp program to create a structure, assign a value to it, and call it.

using static System.Console;

public class NewClass
{  // NewClass
   // 成员变量
 public int x;
 public int y;
}

public struct NewStruct
{  // NewStruct
 // 成员变量
 public int x;
 public int y;
}

class Program
{
 static void Main(string[] args)
 {
  Write("\n\nCreate a structure and assign the value and call it :\n");
  Write("---------------------------------------------------------\n");

  // 创建类的实力并赋值
  NewClass classNum1 = new NewClass();
  classNum1.x = 75;
  classNum1.y = 95;

  // 创建 NewClass 的另一个实例并将其赋值为 ClassNum1
  NewClass classNum2 = classNum1;

  // 修改 classNum1 的值
  classNum1.x = 7500;
  classNum1.y = 9500;

  // 修改 classNum1 后打印 classNum2 的值
  WriteLine($"\nAssign in Class:       x:{classNum2.x},   y:{classNum2.y}");

  // 创建 NewStruct 的结构实力并赋值
  NewStruct structNum1 = new NewStruct();
  structNum1.x = 750;
  structNum1.y = 950;

  // 创建另一个结构并使用 structNum1 赋值
  NewStruct structNum2 = structNum1;

  // 修改 structNum1 的值
  structNum1.x = 75;
  structNum1.y = 95;

  // 修改后打印 structNum2 的值
  WriteLine($"Assign in Structure:   x:{structNum2.x},    y:{structNum2.y}\n\n");
 }
}